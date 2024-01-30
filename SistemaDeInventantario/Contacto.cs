using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventantario
{
    public partial class Contacto : Form
    {
        const String Usuario = "marfenox@gmail.com";
        const String Password = "rnsfnexaeaupzlgt";
        public Contacto()
        {
            InitializeComponent();
            Alerta.Visible=false;

            DoubleBuffered = true;
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

        public static void EnviarCorreo(StringBuilder Mensaje, String De,String Para,String Asunto, String Nombre, String Apellido,out String Error)
        {

            Para = Usuario;
            Error = "";
            try

            {
                Mensaje.Append(Environment.NewLine);
                
                Mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(De);
                mail.To.Add(Para);
                mail.Subject = Asunto;
                mail.Body = Mensaje.ToString();
                SmtpClient Smtp = new SmtpClient("Smtp.gmail.com");
                Smtp.Port = 587;
                Smtp.UseDefaultCredentials = false;
                Smtp.Credentials = new System.Net.NetworkCredential(Usuario,Password);
                Smtp.EnableSsl = true;
                Smtp.Send(mail);
          


}
            catch (Exception Ex)
            {
                Error = "error" + Ex.Message;
                throw;
            }


        }



        private void EnviarMens_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                String Nombre = MensNom.Text ;
                String Apellido = MensApe.Text;
                String De = MensCorreo.Text;
                String Mensaje1 = Mensa.Text;
                String Mensaje2 = Mensaje1 + " Muchas gracias por su atencion Atte: Usuario " + Nombre + " " + Apellido + " " + De + " ";
                String Asunto = "Soporte Tecnico Usuario " + Nombre + " " + Apellido;
                String Error = "";
                StringBuilder MensajeBuilder = new StringBuilder();
                MensajeBuilder.Append(Mensaje2.Trim());


                if (Nombre == String.Empty && Apellido == String.Empty && De == String.Empty && Mensaje1 == String.Empty )
                {
                    Alerta.Visible = true;
                    Alerta.Text = "Los campos Nombre, Apellidos, E-Mail y Mensaje son requeridos Por Favor!";

                    return;
                }


                if (Nombre == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "El Campo Nombre es requerido Por Favor!";
                    return;
                }


                if (Apellido == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "El Campo Apellido es requerido Por Favor!";
                    return;
                }

                if (De == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "El Campo Correo es requerido Por Favor!";
                    return;
                }

                if (ValidationMail(MensCorreo.Text) == false)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "E-Mail Invalido Por favor Escribir Uno Valido!";
                    return;

                }


                if (Mensaje1 == String.Empty)
                {
                    Alerta.Visible = true;
                    Alerta.Text = "El Campo Mensaje es requerido Por Favor!";
                    return;
                }


               

                else

                {
                   
                    Alerta.Visible = false;
                    MessageBox.Show("Mensaje Enviado");
                    EnviarCorreo(MensajeBuilder, De,Usuario,Asunto,Nombre,Apellido,out Error);
                    Mensa.Clear();
                    MensNom.Clear();
                    MensCorreo.Clear();
                    MensApe.Clear();


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
