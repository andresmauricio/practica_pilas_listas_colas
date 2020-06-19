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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            Pila myPila = new Pila();
            myPila.Show();
            this.Hide();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            Lista myLista = new Lista();
            myLista.Show();
            this.Hide();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            Cola myCola = new Cola();
            myCola.Show();
            this.Hide();
        }
    }
}
