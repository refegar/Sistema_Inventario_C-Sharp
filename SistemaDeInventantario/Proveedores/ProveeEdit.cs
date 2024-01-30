using SistemaDeInventantario.App_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using SistemaDeInventantario.Proveedores;

namespace SistemaDeInventantario.Proveedores
{
    public partial class ProveeEdit : Form
    {
        public ProveeEdit()
        {

            InitializeComponent();
            AbrirFormData();
            Inicio.Visible = false;
            EnviarP.Visible = false;
        }

        private void AddPage()
        {

            AgregarP.Visible = false;

        }

        private void AgregarMateria_Click(object sender, EventArgs e)
        {
            //AbrirFormDataAdd();
            Inicio.Visible = true;
            AgregarP.Visible = false;
        }

        private void AbrirFormData()
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);

            ProveeGrid Frm = new ProveeGrid(this);

#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.TopLevel = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.Dock = DockStyle.Fill;
            panel2.Controls.Add(Frm);
            panel2.Tag = Frm;
            Frm.Show();

        }

        private void AbrirFormDataAdd()
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);

            ProveeAdd Frm = new ProveeAdd(this);

#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.TopLevel = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.Dock = DockStyle.Fill;
            panel2.Controls.Add(Frm);
            panel2.Tag = Frm;
            Frm.Show();

        }

       

        private void Inicio_Click_1(object sender, EventArgs e)
        {
            AbrirFormData();
            AgregarP.Visible = true;
            Inicio.Visible = false;
          

        }

        private void AgregarP_Click(object sender, EventArgs e)
        {
            AbrirFormDataAdd();
            AgregarP.Visible = false;
            Inicio.Visible = true;
        }

        private void EnviarP_Click(object sender, EventArgs e)
        {
            AbrirFormData();
            AgregarP.Visible = true;
            Inicio.Visible = false;
            EnviarP.Visible = false;
        }
    }





}

