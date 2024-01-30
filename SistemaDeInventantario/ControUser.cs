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

namespace SistemaDeInventantario
{

    public partial class ControUser : Form
    {
        
        public ControUser()
        {
            DoubleBuffered = true;

            InitializeComponent();
            AbrirFormData();


            Inicio.Visible = false;
            Enviar.Visible = false;

           
        }

        private void AddPage()
        {

            Agregar.Visible = false;

        }

        private void Agregar_Click(object sender, EventArgs e)

        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);


           
            AddUser ? Frm = new AddUser(this);
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.TopLevel = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.Dock = DockStyle.Fill;
            panel2.Controls.Add(Frm);
            panel2.Tag = Frm;
            Frm.Show();
            AddPage();
            Inicio.Visible = true;

        }

        private void AbrirFormData()
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);

            DataGrid? Frm = new DataGrid(this);
            
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.TopLevel = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.Dock = DockStyle.Fill;
            panel2.Controls.Add(Frm);
            panel2.Tag = Frm;
            Frm.Show();

        }
       
        private void Volver_Click(object sender, EventArgs e)
        {
            AbrirFormData();
            Agregar.Visible = true;
            Inicio.Visible = false;
            Enviar.Visible = false;
        }

        private void Enviar_Click_1(object sender, EventArgs e)
        {
            AbrirFormData();
            Agregar.Visible = true;
            Enviar.Visible = false;
            Inicio.Visible = false;
        }

      

        /// /////////////////////////////////////////////////////////////






    }
    }

