namespace Exercicio3
{
    public class Assalariado : Empregado
    {
        private double Salario { get; set; }

        public Assalariado(string nome, string sobrenome, string cpf, double salario)
            : base(nome, sobrenome, cpf)
        {
            Salario = salario;
        }

        public override double Vencimento()
        {
            return Salario;
        }
    }
}
