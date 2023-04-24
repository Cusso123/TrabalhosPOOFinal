namespace ConsoleApp1

{
    internal class Hexagono : Forma
    {
        public double LadoH1;
        public override void CalcularArea()
        {
            double p = LadoH1 * 6;

            Area = (3 * Math.Sqrt(3) / 2) * Math.Pow(LadoH1, 2);
        }

        public override void CalcularPerimetro()
        {
            Perimetro = LadoH1 * 6;
        }
    }
}
