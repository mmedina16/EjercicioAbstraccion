﻿
namespace EjercicioAbstraccion
{
    public class AreaCirculo : FormulaMatematica
    {
        private double radio;

        public AreaCirculo(double radio)
        {
            this.radio = radio;
        }

        public override double Calcular()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El área del círculo con radio {radio} es: {Calcular()}");
        }
    }
}
