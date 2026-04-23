using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POCCarro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblIcono_Click(object sender, EventArgs e)
        {

        }

        private void mnuAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar fAgregar = new FormAgregar();
            fAgregar.ShowDialog();
        }

        private void mnuListar_Click(object sender, EventArgs e)
        {
            FormListar fListar = new FormListar();
            fListar.ShowDialog();
        }

        private void mnuConsultar_Click(object sender, EventArgs e)
        {
            FormConsultar fConsultar = new FormConsultar();
            fConsultar.ShowDialog();
        }

        private void mnuActualizar_Click(object sender, EventArgs e)
        {
            FormBuscarActualizar fBuscarActualizar = new FormBuscarActualizar();
            fBuscarActualizar.ShowDialog();
        }

        private void mnuEliminar_Click(object sender, EventArgs e)
        {
            FormBuscarEliminar fBuscarEliminar = new FormBuscarEliminar();
            fBuscarEliminar.ShowDialog();
        }

        private void mnuAcercaDe_Click(object sender, EventArgs e)
        {
            FormAcercaDe fAcercaDe = new FormAcercaDe();
            fAcercaDe.ShowDialog();
        }

        private void vehiculosMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
