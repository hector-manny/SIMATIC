using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SIMATIC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MenuVertical.Width = 50;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconResaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconResaurar.Visible = false;
            iconMaxi.Visible = true;
        }

        private void iconMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconMaxi.Visible = false;
            iconResaurar.Visible = true;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuDesplegable_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 173)
                MenuVertical.Width = 50;
            else
                MenuVertical.Width = 173;
        }       

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            if (MenuVertical.Width == 50)
                MenuVertical.Width = 173;
        }

        private void btnSesion_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnClientes_MouseMove(object sender, MouseEventArgs e)
        {
            if (MenuVertical.Width == 50)
                MenuVertical.Width = 173;
        }

        private void btnProductos_MouseMove(object sender, MouseEventArgs e)
        {
            if (MenuVertical.Width == 50)
                MenuVertical.Width = 173;
        }

        private void btnProveedores_MouseMove(object sender, MouseEventArgs e)
        {
            if (MenuVertical.Width == 50)
                MenuVertical.Width = 173;
        }

        private void btnFactura_MouseMove(object sender, MouseEventArgs e)
        {
            if (MenuVertical.Width == 50)
                MenuVertical.Width = 173;
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnProductos_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnProveedores_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnFactura_MouseLeave(object sender, EventArgs e)
        {

        }

        private void AbrirFormInPanel(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Clientes());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Productos());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Proveedores());
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Factura());
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Usuarios());
        }

        private void MenuVertical_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void MenuVertical_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_MouseMove(object sender, MouseEventArgs e)
        {
            if (MenuVertical.Width == 50)
                MenuVertical.Width = 173;
        }

        private void PanelContenedor_MouseMove(object sender, MouseEventArgs e)
        {
            if (MenuVertical.Width == 173)
                MenuVertical.Width = 50;
        }

        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (MenuVertical.Width == 173)
                MenuVertical.Width = 50;
        }
    }
}
