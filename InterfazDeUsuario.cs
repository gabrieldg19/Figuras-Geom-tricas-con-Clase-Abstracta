using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geométricas_con_Clase_Abstracta
{
    class InterfazDeUsuario
    {
        public void Iniciar()
        {
            while (true)
            {
                Console.WriteLine("Seleccione una figura geométrica:");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Rectángulo");
                Console.WriteLine("3. Triángulo");
                Console.WriteLine("4. Salir");

                string opcion = Console.ReadLine();

                if (opcion == "4") break;

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el radio del círculo: ");
                        double radio = double.Parse(Console.ReadLine());
                        Circulo circulo = new Circulo(radio);
                        MostrarResultados(circulo);
                        break;

                    case "2":
                        Console.Write("Ingrese el largo del rectángulo: ");
                        double largo = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el ancho del rectángulo: ");
                        double ancho = double.Parse(Console.ReadLine());
                        Rectangulo rectangulo = new Rectangulo(largo, ancho);
                        MostrarResultados(rectangulo);
                        break;

                    case "3":
                        Console.Write("Ingrese la base del triángulo: ");
                        double baseTri = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura del triángulo: ");
                        double altura = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el lado 1 del triángulo: ");
                        double lado1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el lado 2 del triángulo: ");
                        double lado2 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el lado 3 del triángulo: ");
                        double lado3 = double.Parse(Console.ReadLine());
                        Triangulo triangulo = new Triangulo(baseTri, altura, lado1, lado2, lado3);
                        MostrarResultados(triangulo);
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        static void MostrarResultados(FiguraGeometrica figura)
        {
            Console.WriteLine($"{figura.Nombre} - Área: {figura.CalcularArea()}");
            Console.WriteLine($"{figura.Nombre} - Perímetro: {figura.CalcularPerimetro()}");
        }
    }
}