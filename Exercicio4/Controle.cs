namespace Exercicio4
{
    public class Controle
    {
        public List<Funcionario> Funcionarios { get; set; }

        public Controle()
        {
            Funcionarios = new List<Funcionario>();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public void MostrarOsDependentes()
        {
            foreach (Funcionario func in Funcionarios)
            {
                func.MostrarDependentes();
            }
        }
    }
}