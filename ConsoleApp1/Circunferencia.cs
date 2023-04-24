namespace ConsoleApp1

{
    internal class Circunferencia : Forma
    {
        public double raio;

        public override void CalcularArea()
        {
            Area = 3.14 * Math.Pow(raio, 2); 

        }

        public override void CalcularPerimetro()
        {
            Perimetro = (2 * 3.14) * raio;
        }

    }
}
 