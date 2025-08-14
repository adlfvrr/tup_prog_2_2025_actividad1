using ej1.Models;
namespace ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Ortoedro objeto1 = new Ortoedro(3, 3, 6);
            Cubo objeto2 = new Cubo(5);
            Cilindro objeto3 = new Cilindro(1, 3);
            tbPrueba.Text = objeto1.Describir() + objeto2.Describir() + objeto3.Describir();
        }
    }
}
