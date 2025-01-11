namespace KaraokeCurso.Presentacion
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMesas = new System.Windows.Forms.Button();
            this.btnGenerarQR = new System.Windows.Forms.Button();
            this.btnPedir = new System.Windows.Forms.Button();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCantPedidos = new System.Windows.Forms.Panel();
            this.lblCantPedidos = new System.Windows.Forms.Label();
            this.PanelPadre = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerPedidos = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelCantPedidos.SuspendLayout();
            this.PanelPadre.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnMesas);
            this.panel1.Controls.Add(this.btnGenerarQR);
            this.panel1.Controls.Add(this.btnPedir);
            this.panel1.Controls.Add(this.btnCatalogo);
            this.panel1.Controls.Add(this.btnPedidos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 749);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = global::KaraokeCurso.Properties.Resources.LuxorLimpio;
            this.pictureBox2.Location = new System.Drawing.Point(0, 662);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnMesas
            // 
            this.btnMesas.BackColor = System.Drawing.Color.Transparent;
            this.btnMesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMesas.FlatAppearance.BorderSize = 0;
            this.btnMesas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMesas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesas.ForeColor = System.Drawing.Color.White;
            this.btnMesas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMesas.Location = new System.Drawing.Point(0, 242);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(154, 58);
            this.btnMesas.TabIndex = 5;
            this.btnMesas.Text = "Mesas";
            this.btnMesas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMesas.UseVisualStyleBackColor = false;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // btnGenerarQR
            // 
            this.btnGenerarQR.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerarQR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerarQR.FlatAppearance.BorderSize = 0;
            this.btnGenerarQR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGenerarQR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGenerarQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarQR.ForeColor = System.Drawing.Color.White;
            this.btnGenerarQR.Image = global::KaraokeCurso.Properties.Resources.codigoQr369;
            this.btnGenerarQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarQR.Location = new System.Drawing.Point(0, 184);
            this.btnGenerarQR.Name = "btnGenerarQR";
            this.btnGenerarQR.Size = new System.Drawing.Size(154, 58);
            this.btnGenerarQR.TabIndex = 4;
            this.btnGenerarQR.Text = "Generar\r\ncodigos QR";
            this.btnGenerarQR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarQR.UseVisualStyleBackColor = false;
            this.btnGenerarQR.Click += new System.EventHandler(this.btnGenerarQR_Click);
            // 
            // btnPedir
            // 
            this.btnPedir.BackColor = System.Drawing.Color.Transparent;
            this.btnPedir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedir.FlatAppearance.BorderSize = 0;
            this.btnPedir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPedir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPedir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedir.ForeColor = System.Drawing.Color.White;
            this.btnPedir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPedir.Location = new System.Drawing.Point(0, 126);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(154, 58);
            this.btnPedir.TabIndex = 3;
            this.btnPedir.Text = "Pedir";
            this.btnPedir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPedir.UseVisualStyleBackColor = false;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.BackColor = System.Drawing.Color.Transparent;
            this.btnCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalogo.FlatAppearance.BorderSize = 0;
            this.btnCatalogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCatalogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogo.ForeColor = System.Drawing.Color.White;
            this.btnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCatalogo.Location = new System.Drawing.Point(0, 68);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(154, 58);
            this.btnCatalogo.TabIndex = 2;
            this.btnCatalogo.Text = "Catalogo";
            this.btnCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCatalogo.UseVisualStyleBackColor = false;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPedidos.Location = new System.Drawing.Point(0, 10);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(154, 58);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.panelCantPedidos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(154, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(31, 749);
            this.panel2.TabIndex = 1;
            // 
            // panelCantPedidos
            // 
            this.panelCantPedidos.BackgroundImage = global::KaraokeCurso.Properties.Resources.CirculoRojo;
            this.panelCantPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCantPedidos.Controls.Add(this.lblCantPedidos);
            this.panelCantPedidos.Location = new System.Drawing.Point(1, 26);
            this.panelCantPedidos.Name = "panelCantPedidos";
            this.panelCantPedidos.Size = new System.Drawing.Size(28, 26);
            this.panelCantPedidos.TabIndex = 0;
            // 
            // lblCantPedidos
            // 
            this.lblCantPedidos.BackColor = System.Drawing.Color.Transparent;
            this.lblCantPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCantPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPedidos.ForeColor = System.Drawing.Color.White;
            this.lblCantPedidos.Location = new System.Drawing.Point(0, 0);
            this.lblCantPedidos.Name = "lblCantPedidos";
            this.lblCantPedidos.Size = new System.Drawing.Size(28, 26);
            this.lblCantPedidos.TabIndex = 0;
            this.lblCantPedidos.Text = "3";
            this.lblCantPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelPadre
            // 
            this.PanelPadre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.PanelPadre.Controls.Add(this.panel13);
            this.PanelPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPadre.Location = new System.Drawing.Point(185, 0);
            this.PanelPadre.Name = "PanelPadre";
            this.PanelPadre.Size = new System.Drawing.Size(808, 749);
            this.PanelPadre.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label1);
            this.panel13.Location = new System.Drawing.Point(94, 78);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(596, 241);
            this.panel13.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 241);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerPedidos
            // 
            this.timerPedidos.Enabled = true;
            this.timerPedidos.Tick += new System.EventHandler(this.timerPedidos_Tick);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 10);
            this.panel3.TabIndex = 7;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 749);
            this.Controls.Add(this.PanelPadre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luxor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelCantPedidos.ResumeLayout(false);
            this.PanelPadre.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelPadre;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnMesas;
        private System.Windows.Forms.Button btnGenerarQR;
        private System.Windows.Forms.Button btnPedir;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelCantPedidos;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantPedidos;
        private System.Windows.Forms.Timer timerPedidos;
        private System.Windows.Forms.Panel panel3;
    }
}