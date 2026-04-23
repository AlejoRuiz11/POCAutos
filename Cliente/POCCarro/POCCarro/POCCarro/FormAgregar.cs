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
    public partial class FormAgregar : Form
    {

        public FormAgregar()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

        private void FormAgregar_Load_1(object sender, EventArgs e)
        {

        }

        private void numPuertas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient("http://localhost:31230/carros");
                var request = new RestRequest("/", Method.Post);

                // AQUÍ ESTÁ EL CAMBIO CLAVE:
                var nuevoCarro = new
                {
                    matricula = txtMatricula.Text,
                    numeroPuertas = (int)numPuertas.Value,
                    marca = txtMarca.Text,
                    precio = double.Parse(txtPrecio.Text),
                    color = txtColor.Text,
                    fechaRegistro = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")
                };

                request.AddJsonBody(nuevoCarro);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Vehículo guardado correctamente", "Éxito");
                    this.Close();
                }
                else
                {
                    // Esto te dirá si el error es de Java (400, 500, etc)
                    MessageBox.Show("Error del servidor: " + response.StatusCode + " - " + response.Content);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        private void FormAgregar_Load_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
