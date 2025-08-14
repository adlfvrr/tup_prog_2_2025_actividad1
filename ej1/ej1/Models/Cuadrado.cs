using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1.Models
{
    internal class Cuadrado
    {
        double largo;
        double ancho;
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public Cuadrado(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }
        public double CalcularArea()
        {
            return Largo * Ancho;
        }
        public string Describir()
        {
            return $"Cuadrado: Ancho: {Ancho} Largo: {Largo}";
        }
    }
}
