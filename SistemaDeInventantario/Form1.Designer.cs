namespace SistemaDeInventantario
{
    partial class ControlAcceso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlAcceso));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reveal = new System.Windows.Forms.PictureBox();
            this.Entrar = new System.Windows.Forms.Button();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ID_Admin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Panel_Primary = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Alerta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reveal)).BeginInit();
            this.Panel_Primary.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Reveal);
            this.panel1.Controls.Add(this.Entrar);
            this.panel1.Controls.Add(this.Pass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ID_Admin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(399, 196);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 207);
            this.panel1.TabIndex = 6;
            // 
            // Reveal
            // 
            this.Reveal.Image = global::SistemaDeInventantario.Properties.Resources.eye_1915454_640;
            this.Reveal.Location = new System.Drawing.Point(255, 100);
            this.Reveal.Name = "Reveal";
            this.Reveal.Size = new System.Drawing.Size(24, 34);
            this.Reveal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Reveal.TabIndex = 17;
            this.Reveal.TabStop = false;
            this.Reveal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RevealMouseDown);
            this.Reveal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RevealMouseUp);
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.Entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Entrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Entrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Entrar.Location = new System.Drawing.Point(29, 157);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 33);
            this.Entrar.TabIndex = 4;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(29, 105);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(220, 27);
            this.Pass.TabIndex = 3;
            this.Pass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(29, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contraseña:";
            // 
            // ID_Admin
            // 
            this.ID_Admin.AccessibleName = "ID_Num";
            this.ID_Admin.Location = new System.Drawing.Point(29, 40);
            this.ID_Admin.Name = "ID_Admin";
            this.ID_Admin.Size = new System.Drawing.Size(220, 27);
            this.ID_Admin.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(29, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID Admin:";
            // 
            // Panel_Primary
            // 
            this.Panel_Primary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel_Primary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.Panel_Primary.Controls.Add(this.label2);
            this.Panel_Primary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Panel_Primary.Location = new System.Drawing.Point(399, 151);
            this.Panel_Primary.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Primary.Name = "Panel_Primary";
            this.Panel_Primary.Size = new System.Drawing.Size(286, 103);
            this.Panel_Primary.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(58, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Control De Acceso";
            // 
            // Alerta
            // 
            this.Alerta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Alerta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.Alerta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.Alerta.Location = new System.Drawing.Point(399, 402);
            this.Alerta.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.Alerta.Name = "Alerta";
            this.Alerta.Size = new System.Drawing.Size(286, 72);
            this.Alerta.TabIndex = 9;
            this.Alerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ControlAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaDeInventantario.Properties.Resources.platter_gb368becf1_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 621);
            this.Controls.Add(this.Alerta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Primary);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ControlAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control De Acceso";
            this.Load += new System.EventHandler(this.ControlAcceso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reveal)).EndInit();
            this.Panel_Primary.ResumeLayout(false);
            this.Panel_Primary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
   
        private Panel panel1;
        private Button Entrar;
        private TextBox Pass;
        private Label label4;
        private TextBox ID_Admin;
        private Label label3;
        private Panel Panel_Primary;
        private Label label2;
        private Label Alerta;
        private PictureBox Reveal;
    }
}