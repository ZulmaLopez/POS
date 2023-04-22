using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconAceptar_Click(object sender, EventArgs e)
        {
            //Instanciar el Formulario Principal

            frmInicio form = new frmInicio();
            form.Show();
            //Ocultar ventana login
            this.Hide();

            form.FormClosing += frm_closing;
        }

        private void frm_closing(object sender, FormClosingEventArgs e) { 
            this.Show();
            txtConstraseña.Clear();
            txtUsuario.Clear();
        }
    }
}
