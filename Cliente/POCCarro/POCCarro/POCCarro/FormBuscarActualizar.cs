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
    public partial class FormBuscarActualizar : Form
    {
        public FormBuscarActualizar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string placa = txtMatriculaBusqueda.Text.Trim();

                if (string.IsNullOrEmpty(placa))
                {
                    MessageBox.Show("Por favor, ingrese la matrícula.");
                    return;
                }

                var client = new RestClient("http://localhost:31230/carros");
                var request = new RestRequest("/{placa}", Method.Get);
                request.AddUrlSegment("placa", placa);

                var response = client.Execute<Carro>(request);

                if (response.IsSuccessful && response.Data != null)
                {
                    FormActualizar ventanaEdicion = new FormActualizar(response.Data);

                    this.Hide();
                    ventanaEdicion.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vehículo no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
