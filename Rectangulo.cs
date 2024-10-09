using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geométricas_con_Clase_Abstracta
{
    public class Rectangulo : FiguraGeometrica
    {
        private double largo;
        private double ancho;

        public double Largo
        {
            get { return largo; }
            set
            {
                if (value > 0)
                    largo = value;
                else
                    throw new ArgumentException("El largo debe ser mayor que 0.");
            }
        }

        public double Ancho
        {
            get { return ancho; }
            set
            {
                if (value > 0)
                    ancho = value;
                else
                    throw new ArgumentException("El ancho debe ser mayor que 0.");
            }
        }

        public Rectangulo(double largo, double ancho) : base("Rectángulo")
        {
            Largo = largo;
            Ancho = ancho;
        }

        public override double CalcularArea()
        {
            return Largo * Ancho;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }

        ~Rectangulo()
        {
            Console.WriteLine($"Eliminador llamado para {Nombre}");
        }
    }
}