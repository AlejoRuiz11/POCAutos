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
    public partial class FormConsultar : Form
    {
        public FormConsultar()
        {
            InitializeComponent();
        }

        private void FormConsultar_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string placa = txtMatriculaConsulta.Text.Trim();

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
                    var v = response.Data;

                    lblResultado.Text = "INFORMACIÓN DEL VEHÍCULO\n" +
                                        "------------------------------------------\n" +
                                        $"MATRÍCULA: {v.matricula}\n" +
                                        $"MARCA:     {v.marca}\n" +
                                        $"COLOR:     {v.color}\n" +
                                        $"PUERTAS:   {v.numeroPuertas}\n" +
                                        $"PRECIO:    {v.precio:C}\n" +
                                        $"REGISTRO:  {v.fechaRegistro:dd/MM/yyyy}";

                    panelInfo.Visible = true;
                }
                else
                {
                    panelInfo.Visible = false;
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
