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
    public partial class Lista : Form
    {
        List<AreolineaReservaLista> MyAereolinea = new List<AreolineaReservaLista>(); 
        public Lista()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AreolineaReservaLista myAereolinea = new AreolineaReservaLista();
            myAereolinea.CodigoReserva = int.Parse(txtCodigoReserva.Text);
            myAereolinea.Destino = cmbDestino.Text;
            myAereolinea.FechaDeViaje = dtpViaje.Value;
            myAereolinea.ValorTiquete = decimal.Parse(txtValorTiquete.Text);
            MyAereolinea.Add(myAereolinea);
            dgvLista.DataSource = null;
            dgvLista.DataSource = MyAereolinea.ToList();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AreolineaReservaLista myAereolinea = new AreolineaReservaLista();

            if (MyAereolinea.Count != 0)
            {
                foreach (AreolineaReservaLista detail in MyAereolinea)
                {
                    if (detail.CodigoReserva == int.Parse(txtCodigoReserva.Text))
                    {
                        MyAereolinea.Remove(detail);
                    }

                }
            }
            else
            {
                MessageBox.Show("No existen registros");
            }
        }
    }
}
