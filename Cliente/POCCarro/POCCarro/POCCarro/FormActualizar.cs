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
    public partial class FormActualizar : Form
    {
        public FormActualizar(Carro carro)
        {
            InitializeComponent();

            txtMarca.Text = carro.marca;
            txtMatricula.Text = carro.matricula;
            txtColor.Text = carro.color;
            txtPrecio.Text = carro.precio.ToString();
            numPuertas.Value = carro.numeroPuertas;

            txtMatricula.ReadOnly = true;
        }

      
        private void numPuertas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormActualizar_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient("http://localhost:31230/carros");
                var request = new RestRequest("/{placa}", Method.Put);
                request.AddUrlSegment("placa", txtMatricula.Text);

                double precioValido;
                if (!double.TryParse(txtPrecio.Text, out precioValido))
                {
                    MessageBox.Show("Precio no válido");
                    return;
                }

                var carroEditado = new Carro
                {
                    matricula = txtMatricula.Text,
                    marca = txtMarca.Text,
                    color = txtColor.Text,
                    precio = precioValido,
                    numeroPuertas = (int)numPuertas.Value
                };

                request.AddJsonBody(carroEditado);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Actualizado");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblColor_Click(object sender, EventArgs e)
        {

        }
    }
}
