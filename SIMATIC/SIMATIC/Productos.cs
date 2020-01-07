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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void btnCerrarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            pAddProducto.Visible = true;
            pRegistrosProductos.Visible = false;
        }

        private void btnRegistroProducto_Click(object sender, EventArgs e)
        {
            pRegistrosProductos.Visible = true;
            pAddProducto.Visible = false;
        }
    }
}
