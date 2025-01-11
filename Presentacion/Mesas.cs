using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KaraokeCurso.Datos;
using KaraokeCurso.Logica;

namespace KaraokeCurso.Presentacion
{
    public partial class Mesas : UserControl
    {
        public Mesas()
        {
            InitializeComponent();
        }
        int Idmesa;

        private void Mesas_Load(object sender, EventArgs e)
        {
            DibujarMesas();
        }
        private void DibujarMesas()
        {
            try
            {
                panelMesas.Dock = DockStyle.Fill;
                panelContenedorMesas.Controls.Clear();
                DataTable dt = new DataTable();
                Dmesas funcion = new Dmesas();
                funcion.MostrarMesas(ref dt);
                foreach(DataRow rdr in dt.Rows)
                {
                    Button btnMesa = new Button();
                    Button btnEditar = new Button();
                    Button btnEliminar = new Button();
                    Panel panelPrincipal = new Panel();
                    Panel PanelBotones = new Panel();
                    btnMesa.Text = rdr["Mesa"].ToString();
                    btnMesa.Name = rdr["IdMesa"].ToString();
                    btnMesa.Size = new Size(152, 80);
                    btnMesa.Font = new Font("Microsoft Sans Serif", 13);
                    btnMesa.BackColor = Color.Transparent;
                    btnMesa.BackgroundImage = Properties.Resources.verde;
                    btnMesa.BackgroundImageLayout = ImageLayout.Stretch;
                    btnMesa.FlatStyle = FlatStyle.Flat;
                    btnMesa.FlatAppearance.BorderSize = 0;
                    btnMesa.ForeColor = Color.White;
                    btnMesa.Dock = DockStyle.Top;
                    btnMesa.TextAlign = ContentAlignment.MiddleCenter;
                    btnMesa.Cursor = Cursors.Hand;
                    btnMesa.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    btnMesa.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    //***************************
                    btnEditar.Text = "Editar";
                    btnEditar.Name = rdr["Mesa"].ToString();
                    btnEditar.Tag = rdr["IdMesa"].ToString();
                    btnEliminar.Text = "Eliminar";
                    btnEliminar.Name = rdr["IdMesa"].ToString();
                    //******************************
                    btnEditar.Size = new Size(76, 40);
                    btnEditar.Dock = DockStyle.Left;
                    btnEditar.Font = new Font("Microsoft Sans Serif", 10);
                    btnEditar.BackColor = Color.Transparent;
                    btnEditar.BackgroundImage = Properties.Resources.negro;
                    btnEditar.BackgroundImageLayout = ImageLayout.Stretch;
                    btnEditar.FlatStyle = FlatStyle.Flat;
                    btnEditar.FlatAppearance.BorderSize = 0;
                    btnEditar.ForeColor = Color.White;
                    btnEditar.TextAlign = ContentAlignment.MiddleCenter;
                    btnEditar.Cursor = Cursors.Hand;
                    btnEditar.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    btnEditar.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    //***********
                    btnEliminar.Size = new Size(76, 40);
                    btnEliminar.Dock = DockStyle.Left;
                    btnEliminar.Font = new Font("Microsoft Sans Serif", 10);
                    btnEliminar.BackColor = Color.Transparent;
                    btnEliminar.BackgroundImage = Properties.Resources.Rojo;
                    btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
                    btnEliminar.FlatStyle = FlatStyle.Flat;
                    btnEliminar.FlatAppearance.BorderSize = 0;
                    btnEliminar.ForeColor = Color.White;
                    btnEliminar.TextAlign = ContentAlignment.MiddleCenter;
                    btnEliminar.Cursor = Cursors.Hand;
                    btnEliminar.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    btnEliminar.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    //*****************
                    PanelBotones.Size = new Size(76, 40);
                    PanelBotones.Dock = DockStyle.Bottom;
                    //*********************
                    panelPrincipal.Size = new Size(152, 120);
                    //*******************
                    PanelBotones.Controls.Add(btnEditar);
                    PanelBotones.Controls.Add(btnEliminar);
                    panelPrincipal.Controls.Add(btnMesa);
                    panelPrincipal.Controls.Add(PanelBotones);
                    panelContenedorMesas.Controls.Add(panelPrincipal);
                    btnEditar.SendToBack();
                    btnMesa.BringToFront();
                    //***************
                    btnEliminar.Click += BtnEliminar_Click;
                    btnEditar.Click += BtnEditar_Click;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
               
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            btnGuardarCambios.Visible = true;
            btnGuardar.Visible = false;
            panelRegistro.Visible = true;
            panelRegistro.Dock = DockStyle.Fill;
            panelRegistro.BringToFront();
            Idmesa = Convert.ToInt32(((Button)sender).Tag);
            txtmesaedicion.Text = ((Button)sender).Name;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Idmesa =Convert.ToInt32( ((Button)sender).Name);
            EliminarMesa();
        }
        private void EliminarMesa()
        {
            Lmesas parametros = new Lmesas();
            Dmesas funcion = new Dmesas();
            parametros.IdMesa = Idmesa;
            funcion.eliminarMesa(parametros);
            DibujarMesas();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = true;
            panelRegistro.Dock = DockStyle.Fill;
            panelRegistro.BringToFront();
            btnGuardar.Visible = true;
            btnGuardarCambios.Visible = false;
            txtmesaedicion.Clear();
            txtmesaedicion.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarMesas();
        }
        private void InsertarMesas()
        {
            Lmesas parametros = new Lmesas();
            Dmesas funcion = new Dmesas();
            parametros.Mesa = txtmesaedicion.Text;
            if(funcion.Insertar_mesa(parametros)==true)
            {
                panelRegistro.Visible = false;
                DibujarMesas();
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            EditarMesas();
        }
        private void EditarMesas()
        {
            Lmesas parametros = new Lmesas();
            Dmesas funcion = new Dmesas();
            parametros.IdMesa = Idmesa;
            parametros.Mesa = txtmesaedicion.Text;
            if (funcion.editar_mesa(parametros) == true)
            {
                panelRegistro.Visible = false;
                DibujarMesas();
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
        }
    }
}
