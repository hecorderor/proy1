using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace correop1
{

    class Correos
    {
        /*
             * Cliente SMTP
             * Gmail:  smtp.gmail.com  puerto:587
             * Hotmail: smtp.liva.com  puerto:25
             */
        SmtpClient server = new SmtpClient("sistema.ventasp2@gmail.com", 587);

        public Correos()
        {
            /*
             * Autenticacion en el Servidor
             * Utilizaremos nuestra cuenta de correo
             *
             * Direccion de Correo (Gmail o Hotmail)
             * y Contrasena correspondiente
             */
            server.Credentials = new System.Net.NetworkCredential("hellencorderorobles@gmail.com", "svaemniu0696");
            server.EnableSsl = true;
        }

        public void MandarCorreo(MailMessage mensaje)
        {
            server.Send(mensaje);
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Correos Cr = new Correos();
                MailMessage mnsj = new MailMessage();

                mnsj.Subject = "Hola Mundo";
                mnsj.To.Add(new MailAddress("sistema.ventasp2@gmail.com"));

                mnsj.From = new MailAddress("hellencorderorobles@gmail.com", "leith ");

                /* Si deseamos Adjuntar algún archivo*/
                //mnsj.Attachments.Add(new Attachment("C:\\archivo.pdf"));

                mnsj.Body = "  Mensaje de Prueba \n\n Enviado desde C#\n\n *VER EL ARCHIVO ADJUNTO*";

                /* Enviar */
                Cr.MandarCorreo(mnsj);
                //var Enviar = true;

                MessageBox.Show("El Mail se ha Enviado Correctamente", "Listo!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
