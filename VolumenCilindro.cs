
namespace EjercicioAbstraccion
{
    public class VolumenCilindro : FormulaMatematica
    {
        private double radio;
        private double altura;

        public VolumenCilindro(double radio, double altura)
        {
            this.radio = radio;
            this.altura = altura;
        }

        public override double Calcular()
        {
            return Math.PI * Math.Pow(radio, 2) * altura;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El volumen del cilindro con radio {radio} y altura {altura} es: {Calcular()}");
        }
    }
}
