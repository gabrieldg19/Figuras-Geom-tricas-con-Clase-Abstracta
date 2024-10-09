using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geométricas_con_Clase_Abstracta
{
    public abstract class FiguraGeometrica
    {
        public string Nombre { get; set; }

        public FiguraGeometrica(string nombre)
        {
            Nombre = nombre;
            Console.WriteLine($"{nombre} creada.");
        }

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        ~FiguraGeometrica()
        {
            Console.WriteLine($"{Nombre} eliminada.");
        }
    }
}