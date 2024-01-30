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
using SistemaDeInventantario.MateriaPrima;

namespace SistemaDeInventantario
{
    public partial class MateriaPrima1 : Form
    {
        public MateriaPrima1()
        {
            InitializeComponent();
             AbrirFormData();


            Inicio.Visible = false;
            Enviar1.Visible = false;
        }

        private void AddPage()
        {

            Agregar.Visible = false;

        }

        private void AgregarMateria_Click(object sender, EventArgs e)
        {
            AbrirFormDataAdd();
            Inicio.Visible = true;
            AgregarM.Visible = false;
        }

        private void AbrirFormData()
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);

            MateriaGrid Frm = new MateriaGrid(this);

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

            MateriaAdd Frm = new MateriaAdd(this);

#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.TopLevel = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.Dock = DockStyle.Fill;
            panel2.Controls.Add(Frm);
            panel2.Tag = Frm;
            Frm.Show();

        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            AbrirFormData();
            AgregarM.Visible = true;
            Inicio.Visible = false;
            Enviar.Visible = false;
        }

        private void Enviar1_Click(object sender, EventArgs e)
        {
            AbrirFormData();
            AgregarM.Visible = true;
            Inicio.Visible = false;
            Enviar1.Visible = false;
        }


    }
}
