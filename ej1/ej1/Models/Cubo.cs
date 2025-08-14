using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1.Models
{
    internal class Cubo
    {
        Cuadrado[] Caras = new Cuadrado[6];
        public Cubo(double lado)
        {
            Caras[0] = new Cuadrado(lado, lado);
            Caras[1] = new Cuadrado(lado, lado);
            Caras[2] = new Cuadrado(lado, lado);
            Caras[3] = new Cuadrado(lado, lado);
            Caras[4] = new Cuadrado(lado, lado);
            Caras[5] = new Cuadrado(lado, lado);
        }
        public double CalcularArea()
        {
            return Caras[0].CalcularArea() * 6;
        }
        public double CalcularVolumen()
        {
            return Caras[0].Largo * Caras[0].Largo * Caras[0].Largo;
        }
        public string Describir()
        {
            return $@" [ {{
                        ""Tipo"":""Cubo"",
                        ""Lados"":
                        [
                        {{
                        ""Tipo"":""Cuadrado"",
                        ""Largo"":""{Caras[0].Largo:f2}"",
                        ""Ancho"":""{Caras[0].Ancho:f2}"",
                        ""Area"":""{Caras[0].CalcularArea():f2}"",
                        }},
                         {{
                        ""Tipo"":""Cuadrado"",
                        ""Largo"":""{Caras[0].Largo:f2}"",
                        ""Ancho"":""{Caras[0].Ancho:f2}"",
                        ""Area"":""{Caras[0].CalcularArea():f2}"",
                        }},
                        {{
                        ""Tipo"":""Cuadrado"",
                        ""Largo"":""{Caras[0].Largo:f2}"",
                        ""Ancho"":""{Caras[0].Ancho:f2}"",
                        ""Area"":""{Caras[0].CalcularArea():f2}"",
                        }},
                         {{
                        ""Tipo"":""Cuadrado"",
                        ""Largo"":""{Caras[0].Largo:f2}"",
                        ""Ancho"":""{Caras[0].Ancho:f2}"",
                        ""Area"":""{Caras[0].CalcularArea():f2}"",
                        }},
                        {{
                        ""Tipo"":""Cuadrado"",
                        ""Largo"":""{Caras[0].Largo:f2}"",
                        ""Ancho"":""{Caras[0].Ancho:f2}"",
                        ""Area"":""{Caras[0].CalcularArea():f2}"",
                        }},
                        {{
                        ""Tipo"":""Cuadrado"",
                        ""Largo"":""{Caras[0].Largo:f2}"",
                        ""Ancho"":""{Caras[0].Ancho:f2}"",
                        ""Area"":""{Caras[0].CalcularArea():f2}"",
                        }},
                        ],
                        ""Area"":""{CalcularArea():f2}"",
                        ""Volumen"":""{CalcularVolumen():f2}"",
                        }},
                        ]";
        }
    }
}
