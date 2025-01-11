using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KaraokeCurso.Logica;
using KaraokeCurso.Datos;

namespace KaraokeCurso.Presentacion
{
    public partial class Catalogo : UserControl
    {
        public Catalogo()
        {
            InitializeComponent();
        }
        string[] archivo;
        int TotalCanciones;
        int Idcancion;
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Opd = new OpenFileDialog();
            Opd.Filter = "Musica|*.mp3;*.mp4";
            Opd.Multiselect = true;
            Opd.Title = "Cargador de canciones";
            if(Opd.ShowDialog ()==DialogResult.OK)
            {
                Lcanciones parametros = new Lcanciones();
                Dcanciones funcion = new Dcanciones();
                archivo = Opd.SafeFileNames;
                for(int i=0;i<archivo.Length;i++)
                {
                    parametros.Nombre = archivo[i];
                    funcion.insertar_Canciones(parametros);

                }
                MostrarCanciones();
            }
        }
        private void MostrarCanciones()
        {
            DataTable dt = new DataTable();
            Dcanciones funcion = new Dcanciones();
            funcion.MostrarCanciones(ref dt);
            datalistado.DataSource = dt;
            OcultarColumnas();
            Total();
        }
        private void OcultarColumnas()
        {
            datalistado.Columns[1].Visible = false;
        }
        private void Catalogo_Load(object sender, EventArgs e)
        {
            MostrarCanciones();
            
        }
        private void Total()
        {
            Dcanciones funcion = new Dcanciones();
            funcion.TotalCanciones(ref TotalCanciones);
            lblTotal.Text = TotalCanciones.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarTodasCanciones();
        }
        private void EliminarTodasCanciones()
        {
            Dcanciones funcion = new Dcanciones();
            funcion.EliminarTodasCanciones();
            MostrarCanciones();
        }

        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            BuscarCanciones();
        }
        private void BuscarCanciones()
        {
            DataTable dt = new DataTable();
            Dcanciones funcion = new Dcanciones();
            funcion.buscarCanciones(ref dt, txtbusca.Text);
            datalistado.DataSource = dt;
            OcultarColumnas();
        }

        private void datalistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==datalistado.Columns["Eliminar"].Index)
            {
                DialogResult resultado = MessageBox.Show("¿Realmente deseas eliminar esta cancion?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(resultado ==DialogResult.OK)
                {
                    Idcancion = Convert.ToInt32(datalistado.SelectedCells[1].Value);
                    EliminarCancion();
                }
            }
        }
        private void EliminarCancion()
        {
            Lcanciones parametros = new Lcanciones();
            Dcanciones funcion = new Dcanciones();
            parametros.IdCancion = Idcancion;
            if(funcion.eliminar_Canciones(parametros)==true)
            {
                MostrarCanciones();
            }
        }
    }
}
