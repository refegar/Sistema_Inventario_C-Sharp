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

    public partial class AddUser : Form
    {
       
        ControUser controUser;
  
        public AddUser(ControUser controU)

        {

          
            controUser = controU;
            InitializeComponent();
            Alerta.Visible = false;
            
            
        }





        


        private void EditGrid()
        {
            String ID_Admin = EditId.Text;
            String Nombre = EditNom.Text;
            String Apellidos = EditApe.Text;
            String Correo = EditCorreo.Text;
            String Contraseña = EditPass.Text;

            string s = System.Configuration.ConfigurationManager.ConnectionStrings["Sinvopa"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(s))
            {
                sqlCon.Open();

                string query = "INSERT INTO Usuarios " +
                            "values " +
                            "('" + ID_Admin + "','" + Contraseña + "','" + Nombre + "','" + Apellidos + "','" + Correo + "')";

                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("ID_Num", ID_Admin.Trim());
                int cantidad = sqlCmd.ExecuteNonQuery();

                sqlCon.Close();


                
                MessageBox.Show("Datos ya listos para hacer Enviados");
                controUser.Enviar.Visible = true;
                Enviar.Visible = false;
                Alerta.Visible = false;
                EditId.ReadOnly = true;
                EditNom.ReadOnly = true;
                EditApe.ReadOnly = true;
                EditCorreo.ReadOnly = true;
                EditPass.ReadOnly = true;



            }
        }


        public bool ValidationMail(String Correo)
        {
            try
            {
                var validarmail = new System.Net.Mail.MailAddress(Correo);
                return validarmail.Address == Correo;
            }
            catch
            {
                return false;
            }

        }




     

        private void Enviar_Click_1(object sender, EventArgs e)
        {
            try
            {

                String ID_Admin = EditId.Text;
                String Nombre = EditNom.Text;
                String Apellidos = EditApe.Text;
                String Correo = EditCorreo.Text;
                String Contraseña = EditPass.Text;

               
                

                if (Apellidos == String.Empty && Nombre == String.Empty && ID_Admin == String.Empty && Correo == String.Empty
                   )
                {
                    Alerta.Visible = true;
                    Alerta.Text = "Los campos ID Admin , Nombre, Apellidos y E-Mail son requeridos Por Favor!";

                    return;
                }


                if (Nombre == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "El Campo Nombre es requerido Por Favor!";
                    return;
                }


                if (Apellidos == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "El Campo Apellidos es requerido Por Favor!";
                    return;
                }



                if (ID_Admin == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "El Campo ID_Admin es requerido Por Favor!";
                    return;
                }


                if (Contraseña == "Escribir Nueva Contraseña")
                {
                    Alerta.Visible = true;
                    Alerta.Text = "Por Favor escribir una contraseña";
                    return;
                }

                if (ValidationMail(EditCorreo.Text) == false)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "E-Mail Invalido Por favor Escribir Uno Valido!";
                    return;
                }



                else

                {

                    EditGrid();


                }








            }

            catch (Exception)
            {

                Alerta.Visible = true;
                Alerta.Text = "Error Formato Incorrecto El Campo ID_Admin";

            }

        }


       

        private void EditPass_Enter(object sender, EventArgs e)
        {
            if (EditPass.Text == "Escribir Nueva Contraseña")
            {
                EditPass.Text = "";
                EditPass.UseSystemPasswordChar = true;
                EditPass.ForeColor = Color.Black;
            }
        }


        private void EditPass_Leave(object sender, EventArgs e)
        {
            if (EditPass.Text == "")
            {
                EditPass.Text = "Escribir Nueva Contraseña";
                
                EditPass.ForeColor = Color.Silver;
            }
        }

        private void RevealMouseDown(object sender, MouseEventArgs e)
        {
            EditPass.UseSystemPasswordChar = false;
        }

        private void RevealMouseUp(object sender, MouseEventArgs e)
        {
            EditPass.UseSystemPasswordChar = true;
        }


    }
}
