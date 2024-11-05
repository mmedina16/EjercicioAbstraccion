﻿
namespace EjercicioAbstraccion
{
    public class PerimetroRectangulo : FormulaMatematica
    {
        private double largo;
        private double ancho;

        public PerimetroRectangulo(double largo, double ancho)
        {
            this.largo = largo;
            this.ancho = ancho;
        }

        public override double Calcular()
        {
            return 2 * (largo + ancho);
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El perímetro del rectángulo de largo {largo} y ancho {ancho} es: {Calcular()}");
        }
    }
}
