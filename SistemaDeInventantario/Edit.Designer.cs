namespace SistemaDeInventantario
{
    partial class Edit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Reveal = new System.Windows.Forms.PictureBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.Alerta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EditId = new System.Windows.Forms.TextBox();
            this.Enviar = new System.Windows.Forms.Button();
            this.EditCorreo = new System.Windows.Forms.TextBox();
            this.EditPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditApe = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.EditNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reveal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(22, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 434);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.Reveal);
            this.panel2.Controls.Add(this.Id);
            this.panel2.Controls.Add(this.Alerta);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.EditId);
            this.panel2.Controls.Add(this.Enviar);
            this.panel2.Controls.Add(this.EditCorreo);
            this.panel2.Controls.Add(this.EditPass);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.EditApe);
            this.panel2.Controls.Add(this.Label2);
            this.panel2.Controls.Add(this.EditNom);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(48, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 428);
            this.panel2.TabIndex = 4;
            // 
            // Reveal
            // 
            this.Reveal.Image = global::SistemaDeInventantario.Properties.Resources.eye_1915454_640;
            this.Reveal.Location = new System.Drawing.Point(315, 154);
            this.Reveal.Name = "Reveal";
            this.Reveal.Size = new System.Drawing.Size(24, 34);
            this.Reveal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Reveal.TabIndex = 15;
            this.Reveal.TabStop = false;
            this.Reveal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RevealMouseDown);
            this.Reveal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RevealMouseUp);
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(50, 266);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(27, 22);
            this.Id.TabIndex = 14;
            this.Id.Visible = false;
            // 
            // Alerta
            // 
            this.Alerta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Alerta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.Alerta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.Alerta.Location = new System.Drawing.Point(13, 333);
            this.Alerta.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.Alerta.Name = "Alerta";
            this.Alerta.Size = new System.Drawing.Size(326, 72);
            this.Alerta.TabIndex = 13;
            this.Alerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(27, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID Admin:";
            // 
            // EditId
            // 
            this.EditId.Location = new System.Drawing.Point(138, 32);
            this.EditId.Name = "EditId";
            this.EditId.Size = new System.Drawing.Size(168, 22);
            this.EditId.TabIndex = 11;
            // 
            // Enviar
            // 
            this.Enviar.AllowDrop = true;
            this.Enviar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Enviar.AutoSize = true;
            this.Enviar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Enviar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Enviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enviar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Enviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enviar.Location = new System.Drawing.Point(260, 273);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(79, 29);
            this.Enviar.TabIndex = 10;
            this.Enviar.Text = "GUARDAR";
            this.Enviar.UseVisualStyleBackColor = false;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // EditCorreo
            // 
            this.EditCorreo.Location = new System.Drawing.Point(138, 214);
            this.EditCorreo.Name = "EditCorreo";
            this.EditCorreo.Size = new System.Drawing.Size(168, 22);
            this.EditCorreo.TabIndex = 9;
            // 
            // EditPass
            // 
            this.EditPass.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.EditPass.Location = new System.Drawing.Point(138, 168);
            this.EditPass.Name = "EditPass";
            this.EditPass.Size = new System.Drawing.Size(168, 22);
            this.EditPass.TabIndex = 8;
            this.EditPass.Text = "Escribir Nueva Contraseña";
            this.EditPass.Enter += new System.EventHandler(this.EditPass_Enter);
            this.EditPass.Leave += new System.EventHandler(this.EditPass_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña:";
            // 
            // EditApe
            // 
            this.EditApe.Location = new System.Drawing.Point(138, 125);
            this.EditApe.Name = "EditApe";
            this.EditApe.Size = new System.Drawing.Size(168, 22);
            this.EditApe.TabIndex = 5;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(25, 126);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 20);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Apellidos:";
            // 
            // EditNom
            // 
            this.EditNom.Location = new System.Drawing.Point(138, 79);
            this.EditNom.Name = "EditNom";
            this.EditNom.Size = new System.Drawing.Size(168, 22);
            this.EditNom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(452, 466);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reveal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label5;
        public TextBox EditId;
        private Button Enviar;
        public TextBox EditCorreo;
        public TextBox EditPass;
        private Label label4;
        private Label label3;
        public TextBox EditApe;
        private Label Label2;
        public TextBox EditNom;
        private Label label1;
        private Label Alerta;
        public TextBox Id;
        private PictureBox Reveal;
        public Panel panel2;
    }
}