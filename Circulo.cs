using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geométricas_con_Clase_Abstracta
{
    public class Circulo : FiguraGeometrica
    {
        private double radio;

        public double Radio
        {
            get { return radio; }
            set
            {
                if (value > 0)
                    radio = value;
                else
                    throw new ArgumentException("El radio debe ser mayor que 0.");
            }
        }

        public Circulo(double radio) : base("Círculo")
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        ~Circulo()
        {
            Console.WriteLine($"Eliminador llamado para {Nombre}");
        }
    }
}