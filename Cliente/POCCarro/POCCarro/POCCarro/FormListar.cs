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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace POCCarro
{
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient("http://localhost:31230/carros");
                var request = new RestRequest("/filtro", Method.Get);

                string marcaBusqueda = (cbMarca.Text != "Desactivado") ? txtMarcaFiltro.Text.Trim() : "";
                string colorBusqueda = (cbColor.Text != "Desactivado") ? txtColorFiltro.Text.Trim() : "";

                request.AddQueryParameter("marca", marcaBusqueda);
                request.AddQueryParameter("color", colorBusqueda);

                var response = client.Execute<List<Carro>>(request);

                if (response.IsSuccessful && response.Data != null)
                {

                    dgvCarros.DataSource = null;
                    dgvCarros.Rows.Clear(); // Si no usas DataSource, esto limpia filas manuales
                    dgvCarros.Columns.Clear();

                    // 2. Asignar la nueva lista (esto reemplaza la anterior, no la suma)
                    dgvCarros.DataSource = response.Data;

                    dgvCarros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgvCarros.Columns.Count > 0)
                    {
                        dgvCarros.Columns["matricula"].HeaderText = "Matrícula";
                        dgvCarros.Columns["numeroPuertas"].HeaderText = "N° Puertas";
                        dgvCarros.Columns["marca"].HeaderText = "Marca";
                        dgvCarros.Columns["precio"].HeaderText = "Precio";
                        dgvCarros.Columns["color"].HeaderText = "Color";
                        dgvCarros.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
                    }
                }
                else
                {
                    // Limpiamos la tabla también si no hay resultados para que no se queden los viejos
                    dgvCarros.DataSource = null;
                    MessageBox.Show("No se encontraron registros.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormListar_Load(object sender, EventArgs e)
        {

        }
    }
}
