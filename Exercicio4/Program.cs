//Exercicio8
//Crie um controle para armazenar os dados de Funcionários e Dependentes.
//Utilize a lista para armazenar os dependentes dentro da classe Funcionário, além disso, mostre na tela todos os dependentes do funcionário.
//Fique a vontade para adicionar os propriedades e métodos que achar necessário. Crie a Classes Funcionario, Dependente e Controle.
//A classe controle será responsável por manipular o funcionário e seus dependentes. 

using Exercicio4;

Dependente dependente1 = new Dependente("Marcus", "Filho");
Dependente dependente2 = new Dependente("Paulo", "Filho");
Dependente dependente3 = new Dependente("Victor", "Pai");
Dependente dependente4 = new Dependente("Cecilia", "Tia");
Dependente dependente5 = new Dependente("Ana", "Mae");


Funcionario funcionario1 = new Funcionario("Maria", 3000);
funcionario1.AdicionarDependente(dependente1);
funcionario1.AdicionarDependente(dependente2);

Funcionario funcionario2 = new Funcionario("José", 4000);
funcionario2.AdicionarDependente(dependente3);

Funcionario funcionario3 = new Funcionario("Roberta", 7500);
funcionario3.AdicionarDependente(dependente4);
funcionario3.AdicionarDependente(dependente5);

Controle controle1 = new Controle();
controle1.AdicionarFuncionario(funcionario1);
controle1.AdicionarFuncionario(funcionario2);
controle1.AdicionarFuncionario(funcionario3);

controle1.MostrarOsDependentes();