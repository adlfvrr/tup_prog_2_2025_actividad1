using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1.Models
{
    internal class RectanguloDesarrollado
    {
        double ancho;
        double largo;
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public RectanguloDesarrollado(double radio, double altura)
        {
            Largo = altura;
            Ancho = radio * 2 * Math.PI;
        }
        public double CalcularArea()
        {
            return Largo * Ancho;
        }
        public string Describir()
        {
            return $"Rectangulo Desarrollado: Largo: {Largo:f2}, Ancho: {Ancho:f2}";
        }
    }
}
