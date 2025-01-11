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
    public partial class GenerarQR : UserControl
    {
        public GenerarQR()
        {
            InitializeComponent();
        }
        string Ip;
        private void GenerarQR_Load(object sender, EventArgs e)
        {
            ObtenerIpLocal();
        }
        private void ObtenerIpLocal()
        {
            txtIp.Text = Bases.ObtenerIp(ref Ip);
        }
        private void GenerarReporte()
        {
            DataTable dt = new DataTable();
            Dmesas funcion = new Dmesas();
            funcion.mostrarCodigoQR(ref dt);
            CodigosQRMesas rpt = new CodigosQRMesas();
            rpt.DataSource = dt;
            reportViewer1.Visible = true;
            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();
          

        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            EditarIp();
            GenerarReporte();
        }
        private void EditarIp()
        {
            Lestaciones parametros = new Lestaciones();
            Destaciones funcion = new Destaciones();
            parametros.Ip = txtIp.Text;
            funcion.EditarIp(parametros);
        }
    }
}
