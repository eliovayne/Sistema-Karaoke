namespace KaraokeCurso.Presentacion
{
    partial class TomarPedidos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCanciones = new System.Windows.Forms.Panel();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.Pedir = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFelizC = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelMesas = new System.Windows.Forms.Panel();
            this.panelContenedorMesas = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSaludo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPedirC = new System.Windows.Forms.Button();
            this.btnvolverC = new System.Windows.Forms.Button();
            this.txtsaludo = new System.Windows.Forms.RichTextBox();
            this.panelCanciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMesas.SuspendLayout();
            this.panelSaludo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCanciones
            // 
            this.panelCanciones.Controls.Add(this.datalistado);
            this.panelCanciones.Controls.Add(this.panel2);
            this.panelCanciones.Controls.Add(this.label2);
            this.panelCanciones.Location = new System.Drawing.Point(15, 29);
            this.panelCanciones.Name = "panelCanciones";
            this.panelCanciones.Size = new System.Drawing.Size(558, 432);
            this.panelCanciones.TabIndex = 0;
            // 
            // datalistado
            // 
            this.datalistado.AllowUserToAddRows = false;
            this.datalistado.AllowUserToDeleteRows = false;
            this.datalistado.AllowUserToResizeRows = false;
            this.datalistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datalistado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datalistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.ColumnHeadersVisible = false;
            this.datalistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pedir});
            this.datalistado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datalistado.Location = new System.Drawing.Point(0, 111);
            this.datalistado.Name = "datalistado";
            this.datalistado.ReadOnly = true;
            this.datalistado.RowHeadersVisible = false;
            this.datalistado.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.datalistado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalistado.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.datalistado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datalistado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datalistado.RowTemplate.Height = 40;
            this.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado.Size = new System.Drawing.Size(558, 321);
            this.datalistado.TabIndex = 540;
            this.datalistado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalistado_CellClick);
            // 
            // Pedir
            // 
            this.Pedir.HeaderText = "";
            this.Pedir.Image = global::KaraokeCurso.Properties.Resources.avance_rapido;
            this.Pedir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Pedir.Name = "Pedir";
            this.Pedir.ReadOnly = true;
            this.Pedir.Width = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnFelizC);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtbusca);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 57);
            this.panel2.TabIndex = 539;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KaraokeCurso.Properties.Resources.pastel;
            this.pictureBox2.Location = new System.Drawing.Point(359, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnFelizC
            // 
            this.btnFelizC.BackColor = System.Drawing.Color.Transparent;
            this.btnFelizC.BackgroundImage = global::KaraokeCurso.Properties.Resources.rosa;
            this.btnFelizC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFelizC.FlatAppearance.BorderSize = 0;
            this.btnFelizC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFelizC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFelizC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFelizC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFelizC.ForeColor = System.Drawing.Color.White;
            this.btnFelizC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFelizC.Location = new System.Drawing.Point(404, 3);
            this.btnFelizC.Name = "btnFelizC";
            this.btnFelizC.Size = new System.Drawing.Size(135, 50);
            this.btnFelizC.TabIndex = 3;
            this.btnFelizC.Text = "Feliz cumpleaños";
            this.btnFelizC.UseVisualStyleBackColor = false;
            this.btnFelizC.Click += new System.EventHandler(this.btnFelizC_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(18, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 2);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KaraokeCurso.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(303, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtbusca
            // 
            this.txtbusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtbusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbusca.ForeColor = System.Drawing.Color.White;
            this.txtbusca.Location = new System.Drawing.Point(18, 15);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(279, 19);
            this.txtbusca.TabIndex = 0;
            this.txtbusca.TextChanged += new System.EventHandler(this.txtbusca_TextChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 54);
            this.label2.TabIndex = 538;
            this.label2.Text = "Elija una cancion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::KaraokeCurso.Properties.Resources.avance_rapido;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // panelMesas
            // 
            this.panelMesas.Controls.Add(this.panelContenedorMesas);
            this.panelMesas.Controls.Add(this.label1);
            this.panelMesas.Location = new System.Drawing.Point(626, 39);
            this.panelMesas.Name = "panelMesas";
            this.panelMesas.Size = new System.Drawing.Size(221, 219);
            this.panelMesas.TabIndex = 1;
            // 
            // panelContenedorMesas
            // 
            this.panelContenedorMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorMesas.Location = new System.Drawing.Point(0, 54);
            this.panelContenedorMesas.Name = "panelContenedorMesas";
            this.panelContenedorMesas.Size = new System.Drawing.Size(221, 165);
            this.panelContenedorMesas.TabIndex = 540;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 54);
            this.label1.TabIndex = 539;
            this.label1.Text = "Elija una mesa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSaludo
            // 
            this.panelSaludo.Controls.Add(this.btnvolverC);
            this.panelSaludo.Controls.Add(this.btnPedirC);
            this.panelSaludo.Controls.Add(this.groupBox1);
            this.panelSaludo.Location = new System.Drawing.Point(626, 275);
            this.panelSaludo.Name = "panelSaludo";
            this.panelSaludo.Size = new System.Drawing.Size(298, 235);
            this.panelSaludo.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsaludo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Saludo";
            // 
            // btnPedirC
            // 
            this.btnPedirC.BackColor = System.Drawing.Color.Transparent;
            this.btnPedirC.BackgroundImage = global::KaraokeCurso.Properties.Resources.naranja;
            this.btnPedirC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedirC.FlatAppearance.BorderSize = 0;
            this.btnPedirC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPedirC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPedirC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedirC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedirC.ForeColor = System.Drawing.Color.White;
            this.btnPedirC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPedirC.Location = new System.Drawing.Point(5, 170);
            this.btnPedirC.Name = "btnPedirC";
            this.btnPedirC.Size = new System.Drawing.Size(135, 50);
            this.btnPedirC.TabIndex = 4;
            this.btnPedirC.Text = "Pedir";
            this.btnPedirC.UseVisualStyleBackColor = false;
            this.btnPedirC.Click += new System.EventHandler(this.btnPedirC_Click);
            // 
            // btnvolverC
            // 
            this.btnvolverC.BackColor = System.Drawing.Color.Transparent;
            this.btnvolverC.BackgroundImage = global::KaraokeCurso.Properties.Resources.negro;
            this.btnvolverC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvolverC.FlatAppearance.BorderSize = 0;
            this.btnvolverC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnvolverC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnvolverC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolverC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolverC.ForeColor = System.Drawing.Color.White;
            this.btnvolverC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvolverC.Location = new System.Drawing.Point(146, 170);
            this.btnvolverC.Name = "btnvolverC";
            this.btnvolverC.Size = new System.Drawing.Size(135, 50);
            this.btnvolverC.TabIndex = 5;
            this.btnvolverC.Text = "Volver";
            this.btnvolverC.UseVisualStyleBackColor = false;
            this.btnvolverC.Click += new System.EventHandler(this.btnvolverC_Click);
            // 
            // txtsaludo
            // 
            this.txtsaludo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsaludo.Location = new System.Drawing.Point(3, 22);
            this.txtsaludo.Name = "txtsaludo";
            this.txtsaludo.Size = new System.Drawing.Size(292, 139);
            this.txtsaludo.TabIndex = 0;
            this.txtsaludo.Text = "";
            // 
            // TomarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.panelSaludo);
            this.Controls.Add(this.panelMesas);
            this.Controls.Add(this.panelCanciones);
            this.Name = "TomarPedidos";
            this.Size = new System.Drawing.Size(968, 539);
            this.Load += new System.EventHandler(this.TomarPedidos_Load);
            this.panelCanciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMesas.ResumeLayout(false);
            this.panelSaludo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCanciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFelizC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbusca;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.DataGridViewImageColumn Pedir;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panelMesas;
        private System.Windows.Forms.FlowLayoutPanel panelContenedorMesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSaludo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnvolverC;
        private System.Windows.Forms.Button btnPedirC;
        private System.Windows.Forms.RichTextBox txtsaludo;
    }
}
