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
    public partial class Categorias : Form
    {

        
        public Categorias()
        {
            
            InitializeComponent();
            CategEdit.DataSource = Enum.GetValues(typeof(CategoriasNum));
            
            //////////////////////////////////////////////////////////////////////

   
        }

        private void CategEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridUsuarios.Rows.Clear();
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Sinvopa"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(s))

            {
                String ViewCategoria = CategEdit.Text;

                sqlCon.Open();
                string query = "SELECT Categoria,Nombre_Producto,Nombre_proveedor FROM MateriaPrima where Categoria = '" + ViewCategoria + "' ";


                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataReader sdr = sqlCmd.ExecuteReader();
                try
                {
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            DataGridUsuarios.Rows.Add(sdr.GetString(0), sdr.GetString(1), sdr.GetString(2));

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

        private void Inicio_Click(object sender, EventArgs e)
        {

        }
    }
}
