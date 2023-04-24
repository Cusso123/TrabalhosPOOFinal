namespace Exercicio3
{
    public class Comissionado : Empregado
    {
        private double TotalDeVenda { get; set; }
        private double TotalDeComissao { get; set; }

        public Comissionado(string NomeB, string SobrenomeB, string CPFB, double TotalVenda, double PorcentagemComissao)
            : base(NomeB, SobrenomeB, CPFB)
        {
            TotalDeVenda = TotalVenda;
            TotalDeComissao = PorcentagemComissao;
        }
        public override double Vencimento()
        {
            return TotalDeVenda * (TotalDeComissao / 100);
        }
    }
}
