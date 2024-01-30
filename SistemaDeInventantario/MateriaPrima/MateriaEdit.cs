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
    public partial class MateriaEdit : Form
    {
        MateriaGrid materiaGrid;
        public MateriaEdit(MateriaGrid materiaG )
        {

            materiaGrid = materiaG;
            InitializeComponent();
            Alerta.Visible = false;

            CategEdit.DataSource = Enum.GetValues(typeof(CategoriasNum));
           

        }




        private void EditGrid()
        {

            String ID_Prod = Id.Text;
            String Producto = EditProd.Text;
            String Proveedor = EditProvee.Text;
            String Cantidad = EditCant.Text;
            var Cant = Cantidad.Replace(",", ".");
            String Categoria = CategEdit.Text;
            var Canteg = Categoria.Replace("_", " ");
            String HoraIngreso = EditIngre.Text;
            var HI = HoraIngreso.Replace("a. m." ,"").Replace("p. m.", "");
            String Lote = EditLote.Text;
            String Vencimiento = EditVence.Text;
            var HV = Vencimiento.Replace("a. m.", "").Replace("p. m.", "");


            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Sinvopa"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(s))
            {
                sqlCon.Open();

                string query = "update MateriaPrima set " +
                   "Nombre_Producto='" + Producto + "' , " +
                   "Nombre_Proveedor='" + Proveedor + "' , " +
                   "Cantidad='" + Cant + "' , " +
                   "Categoria='" + Canteg + "', " +
                   "Fecha_Ingreso='" + HI + "', " +
                   "lote='" + int.Parse(Lote) + "', " +
                   "Vencimiento= '" + HV + "' " +
                   "where ID_Prod='" + int.Parse(ID_Prod) + "' ";


                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                int cantidad = sqlCmd.ExecuteNonQuery();

                sqlCon.Close();
               materiaGrid.DataGridUsuarios.Visible = true;
                materiaGrid.MateriaGrid1();
                this.Hide();
                this.Close();
                MessageBox.Show("Datos Guardados con Exito!");
                Alerta.Visible = false;







            }
        }

        private void Enviar_Click(object sender, EventArgs e)
        {


            try
            {

                String ID_Prod = Id.Text;
                String Producto = EditProd.Text;
                String Proveedor = EditProvee.Text;
                String Cantidad = EditCant.Text;
                String Categoria = CategEdit.Text;
                String HoraIngreso = EditIngre.Text;
                String Lote = EditLote.Text;
                String Vencimiento = EditVence.Text;




                if (Producto == String.Empty && Proveedor == String.Empty && Cantidad == String.Empty && Categoria == String.Empty && HoraIngreso == String.Empty && Lote == String.Empty && Vencimiento == String.Empty )
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
                Alerta.Text = ioEX.Message+"   Solo Valor Decimal   ";

            }


        }

      
    }
}
