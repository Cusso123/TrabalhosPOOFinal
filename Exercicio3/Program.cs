// Exercicio 07  - Crie todas as classes abaixo, em que:
// Os atributos da classe, devem ser substituídos por propriedades.
// A classe Empregado é abstrata e os restante das classes são classes concretas. O método vencimento da classe Empregado não deve ser implementado, ou seja, possui apenas a assinatura.
// O cálculo do vencimento da classe assalariado deve apenas retornar um double com o valor do salário.
// O cálculo do vencimento do comissionado deve retornar a porcentagem sobre o total vendido.
// O cálculo do vencimento da classe horista deve retornar a multiplicação das horas trabalhadas pelo preço da hora.
// Crie uma terceira classe chamada Menu ou crie na própria classe Program uma estrutura para receber como entrada o nome e sobrenome, CPF e o salário do empregado, caso seja assalariado, total de venda e comissão, caso seja comissionado ou preço da hora e total de horas trabalhadas, caso seja horista. Em seguida apresentar o salário na tela.

using Exercicio3;

int Opcao = 0;

do
{

    Console.WriteLine("Selecione o tipo do empregado:");
    Console.WriteLine("1 - Assalariado");
    Console.WriteLine("2 - Comissionado");
    Console.WriteLine("3 - Horista");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("");
    Console.Write("A opção escolhida é: ");
    Opcao = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    Empregado empregado = null;

    switch (Opcao)
        {
            case 1:
                Console.WriteLine("Tecle o nome do empregado: ");
                string NomeA = Console.ReadLine();
                Console.WriteLine("Tecle o sobrenome do empregado: ");
                string SobrenomeA = Console.ReadLine();
                Console.WriteLine("Tecle o CPF do empregado: ");
                string CPFA = Console.ReadLine();
                Console.WriteLine("Tecle o salário do empregado:");
                double Salario = double.Parse(Console.ReadLine());
                empregado = new Assalariado(NomeA, SobrenomeA, CPFA, Salario);
                Console.WriteLine("");
                Console.WriteLine($"Empregado: {NomeA} {SobrenomeA} - Salário: {empregado.Vencimento()}");
                Console.WriteLine("");
            break;
            case 2:
                Console.WriteLine("Tecle o nome do empregado: ");
                string NomeB = Console.ReadLine();
                Console.WriteLine("Tecle o sobrenome do empregado: ");
                string SobrenomeB = Console.ReadLine();
                Console.WriteLine("Tecle o CPF do empregado: ");
                string CPFB = Console.ReadLine();
                Console.WriteLine("Tecle o total de vendas do empregado:");
                double TotalDeVenda = double.Parse(Console.ReadLine());
                Console.WriteLine("Tecle a porcentagem da comissão do empregado:");
                double PorcentagemDaComissao = double.Parse(Console.ReadLine());
                empregado = new Comissionado(NomeB, SobrenomeB, CPFB, TotalDeVenda, PorcentagemDaComissao);
                Console.WriteLine("");
                Console.WriteLine($"Empregado: {NomeB} {SobrenomeB} - Salário: {empregado.Vencimento()}");
                Console.WriteLine("");
            break;
            case 3:
                Console.WriteLine("Tecle o nome do empregado: ");
                string NomeC = Console.ReadLine();
                Console.WriteLine("Tecle o sobrenome do empregado: ");
                string SobrenomeC = Console.ReadLine();
                Console.WriteLine("Tecle o CPF do empregado: ");
                string CPFC = Console.ReadLine();
                 Console.WriteLine("Tecle o preço da hora do empregado:");
                double PrecoHora = double.Parse(Console.ReadLine());
                Console.WriteLine("Tecle o total de horas trabalhadas do empregado:");
                double HorasTrabalhadas = double.Parse(Console.ReadLine());
                empregado = new Horista(NomeC, SobrenomeC, CPFC, PrecoHora, HorasTrabalhadas);
                Console.WriteLine("");
                Console.WriteLine($"Empregado: {NomeC} {SobrenomeC} - Salário: {empregado.Vencimento()}");
                Console.WriteLine("");
            break;

            case 4:
                Console.WriteLine("Saindo...");
            break;

            default:
                Console.WriteLine("Escolha outra opção, porque essa é inválida!");
            break;
    }

} while (Opcao != 4);

Console.ReadKey();