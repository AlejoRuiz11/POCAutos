using System;
using System.Windows.Forms;

namespace POCCarro
{
    public partial class FormAgregar : Form
    {
     
    }

    public class Carro
    {
        public string matricula { get; set; }
        public int numeroPuertas { get; set; }
        public string marca { get; set; }
        public double precio { get; set; }
        public string color { get; set; }
        public DateTime fechaRegistro { get; set; }
    }
}
