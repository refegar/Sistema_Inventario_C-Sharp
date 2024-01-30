namespace SistemaDeInventantario
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Header = new System.Windows.Forms.Panel();
            this.Contacto = new System.Windows.Forms.Button();
            this.ControlUser = new System.Windows.Forms.Button();
            this.Categorias = new System.Windows.Forms.Button();
            this.Proveedor = new System.Windows.Forms.Button();
            this.MateriaPrima = new System.Windows.Forms.Button();
            this.Casa = new System.Windows.Forms.Button();
            this.Bienvenida = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarGrid = new System.Windows.Forms.TextBox();
            this.Consul = new System.Windows.Forms.Button();
            this.HoraNow = new System.Windows.Forms.Label();
            this.FechaNow = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.Bienvenida.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.Header.Controls.Add(this.Contacto);
            this.Header.Controls.Add(this.ControlUser);
            this.Header.Controls.Add(this.Categorias);
            this.Header.Controls.Add(this.Proveedor);
            this.Header.Controls.Add(this.MateriaPrima);
            this.Header.Controls.Add(this.Casa);
            this.Header.Location = new System.Drawing.Point(40, 168);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(200, 319);
            this.Header.TabIndex = 0;
            // 
            // Contacto
            // 
            this.Contacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.Contacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contacto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Contacto.Location = new System.Drawing.Point(0, 264);
            this.Contacto.Name = "Contacto";
            this.Contacto.Size = new System.Drawing.Size(200, 55);
            this.Contacto.TabIndex = 6;
            this.Contacto.Text = "Contacto";
            this.Contacto.UseVisualStyleBackColor = false;
            this.Contacto.Click += new System.EventHandler(this.Contacto_Click_1);
            // 
            // ControlUser
            // 
            this.ControlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.ControlUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ControlUser.Location = new System.Drawing.Point(0, 50);
            this.ControlUser.Name = "ControlUser";
            this.ControlUser.Size = new System.Drawing.Size(200, 55);
            this.ControlUser.TabIndex = 8;
            this.ControlUser.Text = "Control Usuarios";
            this.ControlUser.UseVisualStyleBackColor = false;
            this.ControlUser.Click += new System.EventHandler(this.ControlUser_Click_1);
            // 
            // Categorias
            // 
            this.Categorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.Categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Categorias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Categorias.Location = new System.Drawing.Point(0, 212);
            this.Categorias.Name = "Categorias";
            this.Categorias.Size = new System.Drawing.Size(200, 55);
            this.Categorias.TabIndex = 7;
            this.Categorias.Text = "Categorias";
            this.Categorias.UseVisualStyleBackColor = false;
            this.Categorias.Click += new System.EventHandler(this.Categorias_Click);
            // 
            // Proveedor
            // 
            this.Proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.Proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Proveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Proveedor.Location = new System.Drawing.Point(0, 158);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(200, 55);
            this.Proveedor.TabIndex = 5;
            this.Proveedor.Text = "Proveedores";
            this.Proveedor.UseVisualStyleBackColor = false;
            this.Proveedor.Click += new System.EventHandler(this.Proveedor_Click);
            // 
            // MateriaPrima
            // 
            this.MateriaPrima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.MateriaPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MateriaPrima.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MateriaPrima.Location = new System.Drawing.Point(0, 104);
            this.MateriaPrima.Name = "MateriaPrima";
            this.MateriaPrima.Size = new System.Drawing.Size(200, 55);
            this.MateriaPrima.TabIndex = 4;
            this.MateriaPrima.Text = "Materia Prima";
            this.MateriaPrima.UseVisualStyleBackColor = false;
            this.MateriaPrima.Click += new System.EventHandler(this.MateriaPrima_Click);
            // 
            // Casa
            // 
            this.Casa.BackColor = System.Drawing.Color.White;
            this.Casa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Casa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Casa.Location = new System.Drawing.Point(-8, 0);
            this.Casa.Name = "Casa";
            this.Casa.Size = new System.Drawing.Size(218, 55);
            this.Casa.TabIndex = 2;
            this.Casa.Text = "Home";
            this.Casa.UseVisualStyleBackColor = false;
            this.Casa.Click += new System.EventHandler(this.Casa_Click);
            // 
            // Bienvenida
            // 
            this.Bienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bienvenida.BackColor = System.Drawing.Color.Transparent;
            this.Bienvenida.Controls.Add(this.label2);
            this.Bienvenida.Location = new System.Drawing.Point(310, 115);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(675, 494);
            this.Bienvenida.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(-11, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(686, 108);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bienvenido Al Sistema De Inventario En Producción Alimenticia SINVOPA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuscarGrid
            // 
            this.BuscarGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarGrid.Location = new System.Drawing.Point(767, 30);
            this.BuscarGrid.Multiline = true;
            this.BuscarGrid.Name = "BuscarGrid";
            this.BuscarGrid.Size = new System.Drawing.Size(144, 33);
            this.BuscarGrid.TabIndex = 2;
            this.BuscarGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BuscarGrid_keyDown);
            // 
            // Consul
            // 
            this.Consul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Consul.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Consul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consul.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Consul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Consul.Location = new System.Drawing.Point(909, 31);
            this.Consul.Name = "Consul";
            this.Consul.Size = new System.Drawing.Size(76, 31);
            this.Consul.TabIndex = 3;
            this.Consul.Text = "Buscar";
            this.Consul.UseVisualStyleBackColor = false;
            this.Consul.Click += new System.EventHandler(this.Consul_Click);
            // 
            // HoraNow
            // 
            this.HoraNow.BackColor = System.Drawing.Color.Transparent;
            this.HoraNow.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HoraNow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HoraNow.Location = new System.Drawing.Point(40, 26);
            this.HoraNow.Name = "HoraNow";
            this.HoraNow.Size = new System.Drawing.Size(276, 37);
            this.HoraNow.TabIndex = 4;
            this.HoraNow.Text = "label1";
            // 
            // FechaNow
            // 
            this.FechaNow.BackColor = System.Drawing.Color.Transparent;
            this.FechaNow.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FechaNow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FechaNow.Location = new System.Drawing.Point(40, 65);
            this.FechaNow.Name = "FechaNow";
            this.FechaNow.Size = new System.Drawing.Size(288, 37);
            this.FechaNow.TabIndex = 5;
            this.FechaNow.Text = "label3";
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "copyright © 2022 Luis Fernando Garcia ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SistemaDeInventantario.Properties.Resources.platter_gb368becf1_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 621);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaNow);
            this.Controls.Add(this.HoraNow);
            this.Controls.Add(this.Consul);
            this.Controls.Add(this.BuscarGrid);
            this.Controls.Add(this.Bienvenida);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Header.ResumeLayout(false);
            this.Bienvenida.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Header;
        private Button Categorias;
        private Button Contacto;
        private Button Proveedor;
        private Button MateriaPrima;
        private Button Casa;
        private Button ControlUser;
        private Label label2;
        private Button Consul;
        public TextBox BuscarGrid;
        public Panel Bienvenida;
        public Label HoraNow;
        public Label FechaNow;
        private System.Windows.Forms.Timer HoraFecha;
        private Label label1;
    }
}