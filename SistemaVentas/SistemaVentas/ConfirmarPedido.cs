using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;       
using System.Net.Mail;

namespace SistemaVentas
{
    public partial class ConfirmarPedido : Form
    {
        public ConfirmarPedido()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipal abrir = new VentanaPrincipal();
            abrir.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }

}
