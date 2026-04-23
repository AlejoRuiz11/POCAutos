using System;
using System.Windows.Forms;
using RestSharp;

namespace POCCarro
{
    public partial class FormEliminar : Form
    {
        private string matriculaActiva;

        public FormEliminar(Carro v)
        {
            InitializeComponent();

            if (v != null)
            {
                this.matriculaActiva = v.matricula;

                lblResultado.Text = "DATOS DEL VEHÍCULO A ELIMINAR\n" +
                                    "------------------------------------------\n" +
                                    $"MATRÍCULA: {v.matricula}\n" +
                                    $"MARCA:     {v.marca}\n" +
                                    $"COLOR:     {v.color}\n" +
                                    $"PUERTAS:   {v.numeroPuertas}\n" +
                                    $"PRECIO:    {v.precio:C}";

                panelInfo.Visible = true;
            }
        }

        // Cambiado el nombre para que coincida con el Designer
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Seguro que desea eliminar este vehículo?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var client = new RestClient("http://localhost:31230/carros");
                    var request = new RestRequest("/{placa}", Method.Delete);

                    request.AddUrlSegment("placa", matriculaActiva);

                    var response = client.Execute(request);

                    if (response.IsSuccessful)
                    {
                        MessageBox.Show("Eliminado con éxito.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar del servidor.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Métodos vacíos para evitar errores si están referenciados en el Designer
        private void FormEliminar_Load(object sender, EventArgs e) { }
        private void panelVehiculo_Paint(object sender, PaintEventArgs e) { }
    }
}