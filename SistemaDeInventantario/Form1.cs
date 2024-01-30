using System;
using System.Data.SqlClient;
using SistemaDeInventantario.App_Data;


namespace SistemaDeInventantario
{
    public partial class ControlAcceso : Form
    {

        private void RevealMouseDown(object sender, MouseEventArgs e)
        {
            Pass.UseSystemPasswordChar = false;
        }

        private void RevealMouseUp(object sender, MouseEventArgs e)
        {
            Pass.UseSystemPasswordChar = true;
        }

        public ControlAcceso()
        {
            InitializeComponent();

            DoubleBuffered = true;
        }


        private void ControlAcceso_Load(object sender, EventArgs e)
        {
            Alerta.Visible = false;

        }


       

        private  void Entrar_Click(object sender, EventArgs e)
        {
            try
            {


                String? uid = ID_Admin.Text;
                String? password = Pass.Text;

                if (password == String.Empty && uid == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "El campo Contraseña es requerido " + " El campo ID Admin es requerido";
                    return;
                }
                if (uid == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "El campo ID Admin es requerido ";
                    return;
                }
                if (password == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "El campo Contraseña es requerido ";
                    return;

                }
                else
                {
                    Alerta.Visible = false;

                }




                string s = System.Configuration.ConfigurationManager.ConnectionStrings["Sinvopa"].ConnectionString;


                using (SqlConnection sqlCon = new SqlConnection(s))
                   {
                       sqlCon.Open();
                       string query = "select ID_Num, password from Usuarios where ID_Num='" + uid + "' and Password='" + password + "'";
                       SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                       sqlCmd.Parameters.AddWithValue("ID_Num", ID_Admin.Text.Trim());
                       sqlCmd.Parameters.AddWithValue("password", Pass.Text.Trim());
                       int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                       SqlDataReader sdr = sqlCmd.ExecuteReader();
                       if (sdr.Read())
                       {


                           this.Hide();
                           using (Home VentanaHome = new Home(ID_Admin.Text))
                               VentanaHome.ShowDialog(this);
                           this.Close();

                       }
                       else
                       {


                           Alerta.Visible = true;
                           Alerta.Text = "Contraseña Incorrecta Por favor Repetir ";
                       }


                       sqlCon.Close();

                   }

            }


            catch (Exception )
            {

                Alerta.Visible = true;
                Alerta.Text = "Error Formato Incorrecto solo numero enteros Por favor!";

            }





        }




      









    }
}