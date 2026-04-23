using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace POCCarro
{
    public partial class FormBuscarEliminar : Form
    {
        public FormBuscarEliminar()
        {
            InitializeComponent();
        }

        private void btnBuscarEliminar_Click(object sender, EventArgs e)
        {
            string matricula = txtMatriculaBuscarEliminar.Text.Trim();

            if (string.IsNullOrEmpty(matricula))
            {
                MessageBox.Show("Por favor, ingrese una matrícula.");
                return;
            }

            try
            {
                var client = new RestClient("http://localhost:31230/carros");
                var request = new RestRequest("/{placa}", Method.Get);
                request.AddUrlSegment("placa", matricula);

                var response = client.Execute<Carro>(request);

                if (response.IsSuccessful && response.Data != null)
                {
                    FormEliminar ventanaEliminar = new FormEliminar(response.Data);

                    this.Hide();
                    ventanaEliminar.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún vehículo con esa matrícula.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormBuscarEliminar_Load(object sender, EventArgs e)
        {

        }
    }
}
