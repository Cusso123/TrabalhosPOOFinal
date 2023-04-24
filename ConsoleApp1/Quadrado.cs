namespace ConsoleApp1

{
    internal class Quadrado : Forma
    {
        public double LadoQA;

        public override void CalcularArea()
        {
            Area = LadoQA * LadoQA;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = LadoQA * 4;
        }
    }
}
