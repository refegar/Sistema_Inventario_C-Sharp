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
    public partial class DataGrid : Form
    {
        ControUser controUser;
        public DataGrid(ControUser ControU)

        {
            controUser = ControU;
            InitializeComponent();
            DataGrid1();


           
        }


      
            
        
        
        
       


        public void DataGrid1()

        {

            if (DataGridUsuarios.Visible == true)

            {
                controUser.Agregar.Visible = true;
                controUser.Inicio.Visible = false;
            }


            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Sinvopa"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(s))
            {

                sqlCon.Open();
                string query = "SELECT ID,ID_Num,nombre,apellidos,correo,password FROM Usuarios";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataReader sdr = sqlCmd.ExecuteReader();
                try
                {
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            DataGridUsuarios.Rows.Add(sdr.GetInt32(0), sdr.GetInt32(1), sdr.GetString(2),
                                 sdr.GetString(3), sdr.GetString(4));

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


      




        private void DataGridUsuarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           

            try
            {

                if (e.ColumnIndex == 6)
                {

                    controUser.Agregar.Visible = false;
                    controUser.Inicio.Visible = true;
                    String? valorCeldaIDAdmin;
                    String? valorCeldaName;
                    String? valorCeldaApe;
                    String? valorCeldaCorreo;
                    String? valorCeldaID;

                    int Idusuarios;
                    Idusuarios = e.RowIndex;

                    valorCeldaID = DataGridUsuarios.Rows[Idusuarios].Cells[0].Value.ToString();
                    valorCeldaIDAdmin = DataGridUsuarios.Rows[Idusuarios].Cells[1].Value.ToString();
                    valorCeldaName = DataGridUsuarios.Rows[Idusuarios].Cells[2].Value.ToString();
                    valorCeldaApe = DataGridUsuarios.Rows[Idusuarios].Cells[3].Value.ToString();
                    valorCeldaCorreo = DataGridUsuarios.Rows[Idusuarios].Cells[4].Value.ToString();



                   

                    Edit obj = new Edit(this);

                   DataGridUsuarios.Visible = false;
                   obj.Id.Text = valorCeldaID;
                   obj.EditId.Text = valorCeldaIDAdmin;
                   obj.EditNom.Text = valorCeldaName;
                   obj.EditApe.Text = valorCeldaApe;
                   obj.EditCorreo.Text = valorCeldaCorreo;
                   
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
                            string query = "delete from Usuarios where ID='" + deleteCeldaID + "' ";
                            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                            sqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Datos Borrados Con exito!");
                            sqlCon.Close();

                            DataGridUsuarios.Rows.Clear();
                            DataGrid1();

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
