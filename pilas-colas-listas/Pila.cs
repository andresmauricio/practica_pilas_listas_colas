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
    public partial class Pila : Form
    {
        Stack<CanalTelevisionPila> MyPilaCanalTelevision = new Stack<CanalTelevisionPila>(); 
        public Pila()
        {
            InitializeComponent();
        }

        private void saliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CanalTelevisionPila myCanal = new CanalTelevisionPila();
            myCanal.Identificacion = int.Parse(txtIdentificacionUsuario.Text);
            myCanal.Estrato = int.Parse(cmbEstrato.Text);
            myCanal.NombreCanal = cmbNombreCanal.Text;
            myCanal.Ubicacion = cmbUbicacion.Text;
            MyPilaCanalTelevision.Push(myCanal);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = MyPilaCanalTelevision.ToArray();
            LimpiarFormulario();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyPilaCanalTelevision.Count != 0)
            {
                CanalTelevisionPila myCanal = new CanalTelevisionPila();
                myCanal = MyPilaCanalTelevision.Pop();
                txtIdentificacionUsuario.Text = myCanal.Identificacion.ToString();
                cmbEstrato.Text = myCanal.Estrato.ToString();
                cmbNombreCanal.Text = myCanal.NombreCanal;
                cmbUbicacion.Text = myCanal.Ubicacion;
                dataGridView1.DataSource = MyPilaCanalTelevision.ToArray();
                MessageBox.Show("Se elimino el registro");
            }
            else
            {
                MessageBox.Show("No existen registros");
            }
        }

        private void LimpiarFormulario()
        {
            txtIdentificacionUsuario.Clear();
            cmbEstrato.Items.Clear();
        }

    }
}
