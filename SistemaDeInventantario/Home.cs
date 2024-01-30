using SistemaDeInventantario.App_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeInventantario.MateriaPrima;
using SistemaDeInventantario.Proveedores;


namespace SistemaDeInventantario
{
    public partial class Home : Form
    {
        String ID_Administrador;


        public Home(String ID_Admin)
        {
            ID_Administrador = ID_Admin;

            InitializeComponent();
            DoubleBuffered = true;

        }



        private void AbrirFormEnPanel(object formhijo)
        {
            if (this.Bienvenida.Controls.Count > 0)
                this.Bienvenida.Controls.RemoveAt(0);
            ControUser? Frm = formhijo as ControUser;
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.TopLevel = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.Dock = DockStyle.Fill;
            Bienvenida.Controls.Add(Frm);
            Bienvenida.Tag = Frm;
            Frm.Show();
            DoubleBuffered = true;
          
         

        }

        private void AbrirFormMateriaPrima(object formhijo)
        {
            if (this.Bienvenida.Controls.Count > 0)
                this.Bienvenida.Controls.RemoveAt(0);
            MateriaPrima1? Frm = formhijo as MateriaPrima1;
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.TopLevel = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.Dock = DockStyle.Fill;
            Bienvenida.Controls.Add(Frm);
            Bienvenida.Tag = Frm;
            Frm.Show();
            DoubleBuffered = true;
        }

        private void AbrirFormProveedores(object formhijo)
        {
            if (this.Bienvenida.Controls.Count > 0)
                this.Bienvenida.Controls.RemoveAt(0);
            ProveeEdit? Frm = formhijo as ProveeEdit;
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.TopLevel = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.Dock = DockStyle.Fill;
            Bienvenida.Controls.Add(Frm);
            Bienvenida.Tag = Frm;
            Frm.Show();
            DoubleBuffered = true;
        }



        private void AbrirFormCategorias(object formhijo)
        {
            if (this.Bienvenida.Controls.Count > 0)
                this.Bienvenida.Controls.RemoveAt(0);
            Categorias? Frm = formhijo as Categorias;
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.TopLevel = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.Dock = DockStyle.Fill;
            Bienvenida.Controls.Add(Frm);
            Bienvenida.Tag = Frm;
            Frm.Show();
            DoubleBuffered = true;
        }


        private void AbrirFormContacto(object formhijo)
        {
            if (this.Bienvenida.Controls.Count > 0)
                this.Bienvenida.Controls.RemoveAt(0);
            Contacto? Frm = formhijo as Contacto;
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.TopLevel = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.Dock = DockStyle.Fill;
            Bienvenida.Controls.Add(Frm);
            Bienvenida.Tag = Frm;
            Frm.Show();
            DoubleBuffered = true;
        }

        private void AbrirFormConsul(object formhijo)
        {
            if (this.Bienvenida.Controls.Count > 0)
                this.Bienvenida.Controls.RemoveAt(0);
            ConsulGrid? Frm = formhijo as ConsulGrid;
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.TopLevel = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            Frm.Dock = DockStyle.Fill;
            Bienvenida.Controls.Add(Frm);
            Bienvenida.Tag = Frm;
            Frm.Show();
            DoubleBuffered = true;
        }






        private void Casa_Click(object sender, EventArgs e)
        {

        }


        private void ControlUser_Click_1(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            MateriaPrima.BackColor = Color.SteelBlue;
            ControlUser.BackColor = Color.Goldenrod;
            Proveedor.BackColor = Color.SteelBlue;
            Categorias.BackColor = Color.SteelBlue;
            Contacto.BackColor = Color.SteelBlue;
            AbrirFormEnPanel(new ControUser());
           

        }



        private void MateriaPrima_Click(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            MateriaPrima.BackColor = Color.Goldenrod;
            ControlUser.BackColor = Color.SteelBlue;
            Categorias.BackColor = Color.SteelBlue;
            Proveedor.BackColor = Color.SteelBlue;
            Contacto.BackColor = Color.SteelBlue;
            AbrirFormMateriaPrima(new MateriaPrima1());

        }


        private void Proveedor_Click(object sender, EventArgs e)
        {

            DoubleBuffered = true;
            MateriaPrima.BackColor = Color.SteelBlue;
            ControlUser.BackColor = Color.SteelBlue;
            Categorias.BackColor = Color.SteelBlue;
            Proveedor.BackColor = Color.Goldenrod;
       
            AbrirFormProveedores(new ProveeEdit());
        }
 
        private void Categorias_Click(object sender, EventArgs e)
        {

            DoubleBuffered = true;
            MateriaPrima.BackColor = Color.SteelBlue;
            ControlUser.BackColor = Color.SteelBlue;
            Proveedor.BackColor = Color.SteelBlue;
            Contacto.BackColor = Color.SteelBlue;
            Categorias.BackColor = Color.Goldenrod;
            AbrirFormCategorias(new Categorias());
        }

        private void Contacto_Click_1(object sender, EventArgs e)
        {

            DoubleBuffered = true;
            MateriaPrima.BackColor = Color.SteelBlue;
            ControlUser.BackColor = Color.SteelBlue;
            Proveedor.BackColor = Color.SteelBlue;
            Categorias.BackColor = Color.SteelBlue;
            Contacto.BackColor = Color.Goldenrod;
            AbrirFormContacto(new Contacto());
        }

        private void Consul_Click(object sender, EventArgs e)
        {
            AbrirFormConsul(new ConsulGrid(this));
            MateriaPrima.BackColor = Color.SteelBlue;
            ControlUser.BackColor = Color.SteelBlue;
            Proveedor.BackColor = Color.SteelBlue;
            Categorias.BackColor = Color.SteelBlue;
            Contacto.BackColor = Color.SteelBlue;
            BuscarGrid.Clear();
            DoubleBuffered = true;
        }

     

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            HoraNow.Text = DateTime.Now.ToString("hh:mm");
            FechaNow.Text = DateTime.Now.ToLongDateString();


        }

   

        private void BuscarGrid_keyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode==Keys.Enter)
            {

                AbrirFormConsul(new ConsulGrid(this));
                MateriaPrima.BackColor = Color.SteelBlue;
                ControlUser.BackColor = Color.SteelBlue;
                Proveedor.BackColor = Color.SteelBlue;
                Categorias.BackColor = Color.SteelBlue;
                Contacto.BackColor = Color.SteelBlue;
                BuscarGrid.Clear();
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
