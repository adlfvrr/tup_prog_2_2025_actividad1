using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1.Models
{
    internal class Ortoedro
    {
        public Rectangulo[] Laterales = new Rectangulo[4];
        public Rectangulo[] Bases = new Rectangulo[2];
        public Ortoedro(double anchoBase, double ladoComun, double largoLateral)
        {
            Bases[0] = new Rectangulo(anchoBase, ladoComun);
            Bases[1] = new Rectangulo(anchoBase, ladoComun);
            Laterales[0] = new Rectangulo(ladoComun, largoLateral);
            Laterales[1] = new Rectangulo(ladoComun, largoLateral);
            Laterales[2] = new Rectangulo(ladoComun, largoLateral);
            Laterales[3] = new Rectangulo(ladoComun, largoLateral);
        }
        public double CalcularArea()
        {
            double areabase = Bases[0].CalcularArea();
            double arealateral = Laterales[0].CalcularArea();
            return areabase*2 + arealateral*4;
        }
        public double CalcularVolumen()
        {
            return Bases[0].CalcularArea() * Laterales[0].Largo;
        }
        public string Describir()
        {
            return $@"[ {{
                        ""Tipo"": ""Ortoedro"",
                        ""Tapas"":
                            [
                                {{
                             ""Tipo"":""Rectangulo"",
                            ""Largo"":""{Bases[0].Largo:f2}"",
                            ""Ancho"":""{Bases[0].Ancho:f2} "",
                            ""Area"":""{Bases[0].CalcularArea():f2}"",
                            }}, 
                                {{
                               ""Tipo"":""Rectangulo"",
                            ""Largo"":""{Bases[1].Largo:f2}"",
                            ""Ancho"":""{Bases[1].Ancho:f2} "",
                            ""Area"":""{Bases[1].CalcularArea():f2} "",
                            }},
                            ],
                       ""Laterales"":
                            [
                            {{
                              ""Tipo"":""Rectangulo"",
                            ""Largo"":""{Laterales[0].Largo:f2}"",
                            ""Ancho"":""{Laterales[0].Ancho:f2}"",
                            ""Area"":""{Laterales[0].CalcularArea():f2}"",
                            }},
                            {{
                              ""Tipo"":""Rectangulo"",
                            ""Largo"":""{Laterales[1].Largo:f2}"",
                            ""Ancho"":""{Laterales[1].Ancho:f2}"",
                            ""Area"":""{Laterales[1].CalcularArea():f2}"",
                            }},
                            {{
                              ""Tipo"":""Rectangulo"",
                            ""Largo"":""{Laterales[2].Largo:f2}"",
                            ""Ancho"":""{Laterales[2].Ancho:f2}"",
                            ""Area"":""{Laterales[2].CalcularArea():f2}"",
                            }},
                            {{
                              ""Tipo"":""Rectangulo"",
                            ""Largo"":""{Laterales[3].Largo:f2}"",
                            ""Ancho"":""{Laterales[3].Ancho:f2}"",
                            ""Area"":""{Laterales[3].CalcularArea():f2}"",
                            }},
                            ],
                            ""Area"":""{CalcularArea():f2}"",
                            ""Volumen"":""{CalcularVolumen():f2}"",
                            }}, ] ";
                            
        }
    }
}
