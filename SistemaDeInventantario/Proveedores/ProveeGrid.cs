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

    public partial class ProveeGrid : Form
    {
        ProveeEdit proveeEdit;
        public ProveeGrid(ProveeEdit ProveeE)
        {
            proveeEdit = ProveeE;
            InitializeComponent();
            ProveeGrid1();
        }

        public void ProveeGrid1()

        {

            if (DataGridUsuarios.Visible == true)

            {
                proveeEdit.AgregarM.Visible = true;
                proveeEdit.Inicio.Visible = false;
            }


            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Sinvopa"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(s))
            {

                sqlCon.Open();
                string query = "SELECT ID_Prov,Nombre_Proveedor,Nombre_Producto,Categoria,Fecha_ingreso FROM Proveedores";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataReader sdr = sqlCmd.ExecuteReader();
                try
                {
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            DataGridUsuarios.Rows.Add(sdr.GetInt32(0), sdr.GetString(1), sdr.GetString(2),
                                 sdr.GetString(3).Replace("_"," "), sdr.GetDateTime(4));

                        }
                    }


                    sqlCon.Close();
                }


                catch (Exception error)

                {
                    MessageBox.Show(error.ToString());
                }
            }


        }

        private void DataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {

                if (e.ColumnIndex == 6)
                {

                    proveeEdit.AgregarM.Visible = false;
                    proveeEdit.Inicio.Visible = true;
                    DataGridUsuarios.Visible = false;


                    String? valorCeldaIDProd;
                    String? valorCeldaProd;
                    String? valorCeldaProvee;
                    String? valorCeldaCateg;
                    String? valorCeldaIngre;
                 


                    int Idusuarios;
                    Idusuarios = e.RowIndex;

                    valorCeldaIDProd = DataGridUsuarios.Rows[Idusuarios].Cells[0].Value.ToString();
                    valorCeldaProd = DataGridUsuarios.Rows[Idusuarios].Cells[2].Value.ToString();
                    valorCeldaProvee = DataGridUsuarios.Rows[Idusuarios].Cells[1].Value.ToString();
                    valorCeldaCateg = DataGridUsuarios.Rows[Idusuarios].Cells[3].Value.ToString();
                    valorCeldaIngre = DataGridUsuarios.Rows[Idusuarios].Cells[4].Value.ToString();
                






                    EditProveedor obj = new EditProveedor();

                    obj.Id.Text = valorCeldaIDProd;
                    obj.EditProd.Text = valorCeldaProd;
                    obj.EditProvee.Text = valorCeldaProvee;
                    obj.CategEdit.Text = valorCeldaCateg;
                    obj.EditIngre.Text = valorCeldaIngre;
                



#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
                    obj.TopLevel = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
                    obj.Dock = DockStyle.Fill;
                    panel1.Controls.Add(obj);
                    panel1.Tag = obj;
                    obj.Show();
                    DataGridUsuarios.Rows.Clear();


                }



                if (e.ColumnIndex == 5)

                {
                    String? deleteCeldaID;
                    int Idusuarios;
                    Idusuarios = e.RowIndex;

                    deleteCeldaID = DataGridUsuarios.Rows[Idusuarios].Cells[0].Value.ToString();

                    string s = System.Configuration.ConfigurationManager.ConnectionStrings["Sinvopa"].ConnectionString;

                    using (SqlConnection sqlCon = new SqlConnection(s))
                    {


                        DialogResult dialogResult = MessageBox.Show("Estas Segur@?", "Eliminar Los Datos Selecionados", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            sqlCon.Open();
                            string query = "delete from Proveedores where ID_Prov='" + deleteCeldaID + "'";
                            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                            sqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Datos Borrados Con exito!");
                            sqlCon.Close();

                            DataGridUsuarios.Rows.Clear();
                            ProveeGrid1();

                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }


                }


            }

            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
            }



        }
    }
}
