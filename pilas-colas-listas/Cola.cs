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
    public partial class Cola : Form
    {
        Queue<AgenciaMigracionCola> MyAgencia = new Queue<AgenciaMigracionCola>();
        public Cola()
        {
            InitializeComponent();
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgenciaMigracionCola myAgencia = new AgenciaMigracionCola();
            myAgencia.NumeroPasaporte =  int.Parse(txtNumeroPasaporte.Text);
            myAgencia.NombreCompleto = txtNombreCompleto.Text;
            myAgencia.Genero = cmbGenero.Text;
            myAgencia.LugarDeProcedencia = cmbLugarProcedencia.Text;
            myAgencia.FechaDeIngreso = dtpIngreso.Value;
            MyAgencia.Enqueue(myAgencia);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = MyAgencia.ToList();
            ResetDataForm();

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyAgencia.Count != 0)
            {
                AgenciaMigracionCola myAgencia = new AgenciaMigracionCola();
                myAgencia = MyAgencia.Dequeue();
                txtNombreCompleto.Text = myAgencia.NombreCompleto;
                txtNumeroPasaporte.Text = myAgencia.NumeroPasaporte.ToString();
                cmbGenero.Text = myAgencia.Genero;
                cmbLugarProcedencia.Text = myAgencia.LugarDeProcedencia;
                dtpIngreso.Value = myAgencia.FechaDeIngreso;
                dgvDatos.DataSource = MyAgencia.ToList();
                MessageBox.Show("Se elimino el registro de la Cola");
                ResetDataForm();
            }
            else
            {
                MessageBox.Show("No existen registros");
            }
        }

        private void ResetDataForm()
        {
            txtNombreCompleto.Clear();
            txtNumeroPasaporte.Clear();
            cmbGenero.Text = null;
            cmbLugarProcedencia.Text = null;
        }
    }
}
