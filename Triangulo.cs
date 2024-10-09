using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geométricas_con_Clase_Abstracta
{
    public class Triangulo : FiguraGeometrica
    {
        private double baseTriangulo;
        private double altura;
        private double lado1;
        private double lado2;
        private double lado3;

        public double BaseTriangulo
        {
            get { return baseTriangulo; }
            set
            {
                if (value > 0)
                    baseTriangulo = value;
                else
                    throw new ArgumentException("La base debe ser mayor que 0.");
            }
        }

        public double Altura
        {
            get { return altura; }
            set
            {
                if (value > 0)
                    altura = value;
                else
                    throw new ArgumentException("La altura debe ser mayor que 0.");
            }
        }

        public double Lado1
        {
            get { return lado1; }
            set
            {
                if (value > 0)
                    lado1 = value;
                else
                    throw new ArgumentException("El lado1 debe ser mayor que 0.");
            }
        }

        public double Lado2
        {
            get { return lado2; }
            set
            {
                if (value > 0)
                    lado2 = value;
                else
                    throw new ArgumentException("El lado2 debe ser mayor que 0.");
            }
        }

        public double Lado3
        {
            get { return lado3; }
            set
            {
                if (value > 0)
                    lado3 = value;
                else
                    throw new ArgumentException("El lado3 debe ser mayor que 0.");
            }
        }

        public Triangulo(double baseTriangulo, double altura, double lado1, double lado2, double lado3) : base("Triángulo")
        {
            BaseTriangulo = baseTriangulo;
            Altura = altura;
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public override double CalcularArea()
        {
            return (BaseTriangulo * Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }

        ~Triangulo()
        {
            Console.WriteLine($"Eliminador llamado para {Nombre}");
        }
    }
}