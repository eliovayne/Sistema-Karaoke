using KaraokeCurso.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KaraokeCurso.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnGenerarQR_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            GenerarQR control = new GenerarQR();
            control.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(control);
            SeleccionarButton(sender);
        }

       
        
    
        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            Catalogo control = new Catalogo();
            control.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(control);
            SeleccionarButton(sender);
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            Mesas control = new Mesas();
            control.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(control);
            SeleccionarButton(sender);
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            TomarPedidos control = new TomarPedidos();
            control.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(control);
            SeleccionarButton(sender);
        }

        private void timerPedidos_Tick(object sender, EventArgs e)
        {
            ContarPedidos();
        }
        private void ContarPedidos()
        {
            int ContadorPedidos = 0;
            Dpedidos funcion = new Dpedidos();
            funcion.ContarPedidosTodos(ref ContadorPedidos);
            if (ContadorPedidos == 0)
            {
                panelCantPedidos.Visible = false;
            }
            else
            {
                lblCantPedidos.Text = ContadorPedidos.ToString();
                panelCantPedidos.Visible = true;
            }
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            VerPedidos control = new VerPedidos();
            control.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(control);
            SeleccionarButton(sender);
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
       private void SeleccionarButton( Object boton)
        {
            foreach (Control b in panel1.Controls)
            {
                if(b.Name ==((Button)boton).Name)
                {
                    b.BackgroundImage = Properties.Resources.naranja;
                }
                else
                {
                    b.BackgroundImage = null;
                }

            }
        }

     

        
    }
}
