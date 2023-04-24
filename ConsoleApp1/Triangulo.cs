namespace ConsoleApp1

{
    internal class Triangulo : Forma
    {
        public double LadoA;
        public double LadoB;
        public double LadoC;

        public override void CalcularArea()
        {
            double p = (LadoA + LadoB + LadoC) / 2;
            
            Area = Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC)); 
        }

        public override void CalcularPerimetro()
        {
            Perimetro = LadoA + LadoB + LadoC;
        }
    }
}
