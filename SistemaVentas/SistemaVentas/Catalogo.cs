﻿using System;
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
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        private void SalirCP_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipal abrir = new VentanaPrincipal();
            abrir.Show();
        }
    }
}
