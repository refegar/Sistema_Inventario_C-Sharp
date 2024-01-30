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

namespace SistemaDeInventantario.MateriaPrima
{
    public partial class MateriaAdd : Form
    {
        MateriaPrima1 MateriaPrima1;
        public MateriaAdd(MateriaPrima1 MateriaPri)
        {

            
            MateriaPrima1 = MateriaPri;
            InitializeComponent();
            Alerta.Visible = false;
            CategEdit.DataSource = Enum.GetValues(typeof(CategoriasNum));
            //Id.Text = EditIngre.Value.ToString("dd/MMM/yyyy hh:MM:ss");


            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Sinvopa"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(s))
            {
                sqlCon.Open();
                string query = "select Nombre_Proveedor FROM Proveedores";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataReader sdr = sqlCmd.ExecuteReader();
                while (sdr.Read())
                {

                    EditProvee.Items.Add(sdr["Nombre_Proveedor"].ToString());



                }
             


                sqlCon.Close();

            }

        }

        private void EditGrid()
        {

           
            String Producto = EditProd.Text;
            String Proveedor = EditProvee.Text;
            String Cantidad = EditCant.Text;
            var Cant = Cantidad.Replace(",", ".");
            String Categoria = CategEdit.Text;
            var Canteg = Categoria.Replace("_", " ");
            String HoraIngreso = EditIngre.Value.ToString("yyyy/MM/dd hh:mm:ss");
            var HI = HoraIngreso.Replace("a. m.", "").Replace("p. m.", "");
            String Lote = EditLote.Text;
            String Vencimiento = EditVence.Value.ToString("yyyy/MM/dd hh:mm:ss");
            var HV = Vencimiento.Replace("a. m.", "").Replace("p. m.", "");



            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Sinvopa"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(s))

            {
                sqlCon.Open();

                string query = "INSERT INTO MateriaPrima values " +
              "('" + Producto + "','" + Proveedor + "','" + Cant + "','" + Canteg + "','" + HoraIngreso + "','" + Lote + "','" + Vencimiento + "')";


                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
              
                int cantidad = sqlCmd.ExecuteNonQuery();

                sqlCon.Close();

                MessageBox.Show("Datos ya listos para hacer Enviados");
                MateriaPrima1.Enviar1.Visible = true;
                Enviar.Visible = false;
                Alerta.Visible = false;
                EditProd.ReadOnly = true;
                EditCant.ReadOnly = true;
                EditLote.ReadOnly = true;







            }
        }

        private void Enviar_Click(object sender, EventArgs e)
        {

            
            try
            {

                String Producto = EditProd.Text;
                String Proveedor = EditProvee.Text;
                String Cantidad = EditCant.Text;
                String Categoria = CategEdit.Text;
                String HoraIngreso = EditIngre.Text;
                String Lote = EditLote.Text;
                String Vencimiento = EditVence.Text;




                if (Producto == String.Empty && Proveedor == String.Empty && Cantidad == String.Empty && Categoria == String.Empty && HoraIngreso == String.Empty && Lote == String.Empty && Vencimiento == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "Los campos ID Prod, Producto, Proveedor, Cantidad, Categoria, HoraIngreso, Lote y Vencimiento son requeridos Por Favor!";

                    return;
                }

                if (Producto == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "El Campo Producto es requerido Por Favor!";
                    return;
                }

                if (Proveedor == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "El Campo Proveerdor es requerido Por Favor!";
                    return;
                }


                if (Cantidad == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "Por favor! La cantidad ";
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

                if (Lote == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "Por Favor Numero de Lote";
                    return;
                }

                if (Vencimiento == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "Por Favor La fecha de Vencimiento";
                    return;
                }





                else

                {

                    EditGrid();


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
