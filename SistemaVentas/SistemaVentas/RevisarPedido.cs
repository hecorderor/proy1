using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class RevisarPedido : Form 
    {


        Correo c = new Correo();

        public RevisarPedido()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        c.enviarCorreo("sistema.ventasp2@gmail.com", "proyecto2", "Su pedido Fue cancelado", "Estado del Pedido", "hellencorderorobles@gmail.com", "C:\\Users\\helle\\Documents\\ati");

        /*this.Close();
            VentanaPrincipal abrirVP = new VentanaPrincipal();
            abrirVP.Show();*/
        }

        private void RevisarPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
