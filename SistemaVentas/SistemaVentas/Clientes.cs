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

namespace SistemaVentas
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
         
        }

        private void bCancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipal abrirVP = new VentanaPrincipal();
            abrirVP.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static void Main()
        {
            // Get the current date.
            DateTime thisDay = DateTime.Today;
            // Display the date in the default (general) format.
            Console.WriteLine(thisDay.ToString());
            Console.WriteLine();
            // Display the date in a variety of formats.
            Console.WriteLine(thisDay.ToString("d"));
            Console.WriteLine(thisDay.ToString("D"));
            Console.WriteLine(thisDay.ToString("g"));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void bRegistrarCliente_Click(object sender, EventArgs e)
        {
            
        }

        public void tbCorreoCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
