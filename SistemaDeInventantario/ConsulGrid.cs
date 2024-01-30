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
    public partial class ConsulGrid : Form
    {
        Home home;
        public ConsulGrid(Home hom)
        {
            home = hom;
            InitializeComponent();

            string ConsulData;
            ConsulData = home.BuscarGrid.Text;

            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Sinvopa"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(s))
            {

                sqlCon.Open();
                string query = "SELECT * FROM MateriaPrima  where (Nombre_Producto  like '["+ ConsulData + "]%') or (Nombre_proveedor  like '[" + ConsulData + "]%') or (Categoria  like '[" + ConsulData + "]%')";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataReader sdr = sqlCmd.ExecuteReader();
                
                try
                {
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            DataGridUsuarios.Rows.Add(sdr.GetInt32(0), sdr.GetString(1), sdr.GetString(2),
                                 sdr.GetDouble(3), sdr.GetString(4), sdr.GetDateTime(5), sdr.GetInt32(6), sdr.GetDateTime(7));

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


                if (e.ColumnIndex == 9)
                {
                    DataGridUsuarios.Visible = false;
                    label1.Visible = false;

                    String? valorCeldaIDProd;
                    String? valorCeldaProd;
                    String? valorCeldaProvee;
                    String? valorCeldaCant;
                    String? valorCeldaCateg;
                    String? valorCeldaIngre;
                    String? valorCeldaLote;
                    String? valorCeldaVence;


                    int Idusuarios;
                    Idusuarios = e.RowIndex;

                    valorCeldaIDProd = DataGridUsuarios.Rows[Idusuarios].Cells[0].Value.ToString();
                    valorCeldaProd = DataGridUsuarios.Rows[Idusuarios].Cells[1].Value.ToString();
                    valorCeldaProvee = DataGridUsuarios.Rows[Idusuarios].Cells[2].Value.ToString();
                    valorCeldaCant = DataGridUsuarios.Rows[Idusuarios].Cells[3].Value.ToString();
                    valorCeldaCateg = DataGridUsuarios.Rows[Idusuarios].Cells[4].Value.ToString();
                    valorCeldaIngre = DataGridUsuarios.Rows[Idusuarios].Cells[5].Value.ToString();
                    valorCeldaLote = DataGridUsuarios.Rows[Idusuarios].Cells[6].Value.ToString();
                    valorCeldaVence = DataGridUsuarios.Rows[Idusuarios].Cells[7].Value.ToString();






                    ConsulEdit obj = new ConsulEdit(this.home);

                    obj.Id.Text = valorCeldaIDProd;
                    obj.EditProd.Text = valorCeldaProd;
                    obj.EditProvee.Text = valorCeldaProvee;
                    obj.EditCant.Text = valorCeldaCant;
                    obj.CategEdit.Text = valorCeldaCateg;
                    obj.EditIngre.Text = valorCeldaIngre;
                    obj.EditLote.Text = valorCeldaLote;
                    obj.EditVence.Text = valorCeldaVence;


#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
                    obj.TopLevel = false;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
                    obj.Dock = DockStyle.Fill;
                    panel1.Controls.Add(obj);
                    panel1.Tag = obj;
                    obj.Show();
                    DataGridUsuarios.Rows.Clear();


                }




                if (e.ColumnIndex == 8)

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
                            string query = "delete from MateriaPrima where ID_Prod='" + deleteCeldaID + "'";
                            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                            sqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Datos Borrados Con exito!");
                            sqlCon.Close();

                            DataGridUsuarios.Rows.Clear();
                            if (this.home.Bienvenida.Controls.Count > 0)
                                this.home.Bienvenida.Controls.RemoveAt(0);

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
