namespace SistemaDeInventantario.Proveedores
{
    partial class EditProveedor
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
            this.CategEdit = new System.Windows.Forms.TextBox();
            this.EditProd = new System.Windows.Forms.TextBox();
            this.EditProvee = new System.Windows.Forms.TextBox();
            this.EditIngre = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(4, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 278);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.CategEdit);
            this.panel2.Controls.Add(this.EditProd);
            this.panel2.Controls.Add(this.EditProvee);
            this.panel2.Controls.Add(this.EditIngre);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Id);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 241);
            this.panel2.TabIndex = 4;
            // 
            // CategEdit
            // 
            this.CategEdit.Location = new System.Drawing.Point(115, 177);
            this.CategEdit.Name = "CategEdit";
            this.CategEdit.ReadOnly = true;
            this.CategEdit.Size = new System.Drawing.Size(169, 22);
            this.CategEdit.TabIndex = 28;
            // 
            // EditProd
            // 
            this.EditProd.Location = new System.Drawing.Point(115, 95);
            this.EditProd.Name = "EditProd";
            this.EditProd.ReadOnly = true;
            this.EditProd.Size = new System.Drawing.Size(169, 22);
            this.EditProd.TabIndex = 27;
            // 
            // EditProvee
            // 
            this.EditProvee.Location = new System.Drawing.Point(115, 22);
            this.EditProvee.Name = "EditProvee";
            this.EditProvee.ReadOnly = true;
            this.EditProvee.Size = new System.Drawing.Size(169, 22);
            this.EditProvee.TabIndex = 26;
            // 
            // EditIngre
            // 
            this.EditIngre.CustomFormat = "d/MM/yyyy hh:mm:ss";
            this.EditIngre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EditIngre.Location = new System.Drawing.Point(465, 95);
            this.EditIngre.Name = "EditIngre";
            this.EditIngre.Size = new System.Drawing.Size(194, 22);
            this.EditIngre.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(341, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hora Ingreso:";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(341, 189);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(51, 22);
            this.Id.TabIndex = 14;
            this.Id.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Productos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proveedor:";
            // 
            // EditProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(714, 486);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProveedor";
            this.Text = "EditProveedor";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        public Panel panel2;
        private Label label4;
        public TextBox Id;
        private Label label5;
        private Label label3;
        private Label label1;
        public DateTimePicker EditIngre;
        public TextBox CategEdit;
        public TextBox EditProd;
        public TextBox EditProvee;
    }
}