using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasBDConectada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            accesoDatosCliente datosCliente = new accesoDatosCliente();
            List<entidadcliente> ListaCliente = datosCliente.ListarCliente();
            dataGridView1.DataSource = ListaCliente;

        }
    }
}
