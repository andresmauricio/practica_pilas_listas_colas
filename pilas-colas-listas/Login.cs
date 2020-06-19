using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pilas_colas_listas
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            if (!(txtPassword.Text.Any()) || txtPassword.Text != "123")
            {
                MessageBox.Show("Contraseña Incorrecta");
                txtPassword.Clear();
            } else
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }

        }
    }
}
