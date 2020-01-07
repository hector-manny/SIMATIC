using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMATIC
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            pAddCliente.Visible = true;
            pRegistrosCliente.Visible = false;
        }

        private void btnRegistroCliente_Click(object sender, EventArgs e)
        {
            pRegistrosCliente.Visible = true;
            pAddCliente.Visible = false;

        }     

        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
