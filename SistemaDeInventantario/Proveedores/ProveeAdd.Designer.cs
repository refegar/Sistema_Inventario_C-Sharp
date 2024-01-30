namespace SistemaDeInventantario.Proveedores
{
    partial class ProveeAdd
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
            this.EditIngre = new System.Windows.Forms.DateTimePicker();
            this.CategEdit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.Alerta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EditProd = new System.Windows.Forms.TextBox();
            this.Enviar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EditProvee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(7, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 440);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.EditIngre);
            this.panel2.Controls.Add(this.CategEdit);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Id);
            this.panel2.Controls.Add(this.Alerta);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.EditProd);
            this.panel2.Controls.Add(this.Enviar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.EditProvee);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(5, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 426);
            this.panel2.TabIndex = 4;
            // 
            // EditIngre
            // 
            this.EditIngre.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.EditIngre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EditIngre.Location = new System.Drawing.Point(457, 95);
            this.EditIngre.Name = "EditIngre";
            this.EditIngre.Size = new System.Drawing.Size(194, 22);
            this.EditIngre.TabIndex = 23;
            // 
            // CategEdit
            // 
            this.CategEdit.FormattingEnabled = true;
            this.CategEdit.Location = new System.Drawing.Point(119, 178);
            this.CategEdit.Name = "CategEdit";
            this.CategEdit.Size = new System.Drawing.Size(168, 21);
            this.CategEdit.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(331, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hora Ingreso:";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(44, 245);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(51, 22);
            this.Id.TabIndex = 14;
            this.Id.Visible = false;
            // 
            // Alerta
            // 
            this.Alerta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Alerta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.Alerta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.Alerta.Location = new System.Drawing.Point(188, 292);
            this.Alerta.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.Alerta.Name = "Alerta";
            this.Alerta.Size = new System.Drawing.Size(333, 72);
            this.Alerta.TabIndex = 13;
            this.Alerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Producto:";
            // 
            // EditProd
            // 
            this.EditProd.Location = new System.Drawing.Point(119, 93);
            this.EditProd.Name = "EditProd";
            this.EditProd.Size = new System.Drawing.Size(168, 22);
            this.EditProd.TabIndex = 11;
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
            this.Enviar.Location = new System.Drawing.Point(331, 238);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(79, 29);
            this.Enviar.TabIndex = 10;
            this.Enviar.Text = "GUARDAR";
            this.Enviar.UseVisualStyleBackColor = false;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria:";
            // 
            // EditProvee
            // 
            this.EditProvee.Location = new System.Drawing.Point(119, 19);
            this.EditProvee.Name = "EditProvee";
            this.EditProvee.Size = new System.Drawing.Size(168, 22);
            this.EditProvee.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proveedor:";
            // 
            // ProveeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(691, 505);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProveeAdd";
            this.Text = "ProveeAdd";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        public Panel panel2;
        private DateTimePicker EditIngre;
        public ComboBox CategEdit;
        private Label label4;
        public TextBox Id;
        private Label Alerta;
        private Label label5;
        public TextBox EditProd;
        private Button Enviar;
        private Label label3;
        public TextBox EditProvee;
        private Label label1;
    }
}