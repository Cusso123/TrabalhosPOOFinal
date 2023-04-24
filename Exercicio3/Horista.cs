namespace Exercicio3

{ 
        public class Horista : Empregado
    {
        private double PrecoDasHora { get; set; }
        private double HorasDeTrabalho { get; set; }

        public Horista(string NomeC, string SobrenomeC, string CPFC, double PrecoHora, double HorasTrabalhadas)
        : base(NomeC, SobrenomeC, CPFC)
        {
            PrecoDasHora = PrecoHora;
            HorasDeTrabalho = HorasTrabalhadas;
        }

        public override double Vencimento()
        {
        return HorasDeTrabalho * PrecoDasHora;
        }
    }
}