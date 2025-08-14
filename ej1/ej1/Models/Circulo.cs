using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1.Models
{
    internal class Circulo
    {
        double radio;
        public double Radio { get; set; }
        public Circulo(double radio)
        {
            Radio = radio;
        }
        public double CalcularArea()
        {
            return Math.PI * (Radio * Radio);
        }
        public string Describir()
        {
            return $"Circulo: Radio:{Radio:f2}";
        }
    }
}
