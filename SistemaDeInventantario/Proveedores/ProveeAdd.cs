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
    public partial class ProveeAdd : Form
    {
        ProveeEdit proveeEdit;
        public ProveeAdd(ProveeEdit ProveeA)

        {
            proveeEdit = ProveeA;
            InitializeComponent();
            Alerta.Visible = false;
            CategEdit.DataSource = Enum.GetValues(typeof(CategoriasNum));
        }



        private void AddGrid()
        {


            String Producto = EditProd.Text;
            String Proveedor = EditProvee.Text;
            String Categoria = CategEdit.Text;
            var Canteg = Categoria.Replace("_", " ");
            String HoraIngreso = EditIngre.Value.ToString("yyyy/MM/dd hh:mm:ss");





            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Sinvopa"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(s))
            {
                sqlCon.Open();

                string query = "INSERT INTO Proveedores values " +
              "('" + Proveedor + "','" + Producto + "','" + Canteg + "','" + HoraIngreso + "')";


                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);

                int cantidad = sqlCmd.ExecuteNonQuery();

                sqlCon.Close();

                MessageBox.Show("Datos ya listos para hacer Enviados");
                proveeEdit.EnviarP.Visible = true;
                Enviar.Visible = false;
                Alerta.Visible = false;
                EditProd.ReadOnly = true;
                EditProvee.ReadOnly = true;
              








            }
        }

        private void Enviar_Click_1(object sender, EventArgs e)
        {


            try
            {

                String Producto = EditProd.Text;
                String Proveedor = EditProvee.Text;
                String Categoria = CategEdit.Text;
                String HoraIngreso = EditIngre.Text;




                if (Proveedor == String.Empty && Producto == String.Empty && Categoria == String.Empty && HoraIngreso == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "Los campos ID Prod, Producto, Proveedor, Cantidad, Categoria, HoraIngreso, Lote y Vencimiento son requeridos Por Favor!";

                    return;
                }

                if (Proveedor == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "El Campo Proveerdor es requerido Por Favor!";
                    return;
                }


                if (Producto == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "El Campo Producto es requerido Por Favor!";
                    return;
                }




                if (Categoria == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "Por Favor escribir la Categoria";
                    return;
                }

                if (HoraIngreso == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "Por Favor La fecha de ingreso";
                    return;
                }

              
                else

                {

                    AddGrid();


                }








            }

            catch (Exception ioEX)
            {

                Alerta.Visible = true;
                Alerta.Text = ioEX.Message;

            }


        }

    
    }
}
