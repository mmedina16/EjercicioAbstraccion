using System;

using EjercicioAbstraccion;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Seleccione la fórmula que desea calcular:");
            Console.WriteLine("1. Área del Círculo");
            Console.WriteLine("2. Perímetro del Rectángulo");
            Console.WriteLine("3. Volumen del Cilindro");
            Console.WriteLine("4. Salir");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 4) break;

            FormulaMatematica formula = null;

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el radio del círculo: ");
                    double radioCirculo = double.Parse(Console.ReadLine());
                    formula = new AreaCirculo(radioCirculo);
                    break;
                case 2:
                    Console.Write("Ingrese el largo del rectángulo: ");
                    double largo = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el ancho del rectángulo: ");
                    double ancho = double.Parse(Console.ReadLine());
                    formula = new PerimetroRectangulo(largo, ancho);
                    break;
                case 3:
                    Console.Write("Ingrese el radio del cilindro: ");
                    double radioCilindro = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del cilindro: ");
                    double altura = double.Parse(Console.ReadLine());
                    formula = new VolumenCilindro(radioCilindro, altura);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    continue;
            }

            formula.Imprimir();
        }
    }
}