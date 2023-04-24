// Exercicio 06
//Crie um software em ConsoleApp para realizar o controle de impressão de conteúdos que serão digitados pelo usuário.
//A função Imprimir() da classe Impressora deve imprimir o texto na tela de acordo com a quantidade. A quantidade de cópia por padrão sempre será igual a 1. Perceba que existe um
//método construtor na classe, ou seja, para ela funcionar ela precisa receber um objeto do tipo da classe Documento.
//A Classe Imprimir possui a responsabilidade de ter dois métodos para solicitar o texto a ser impresso que será digitado pelo usuário e enviar o documento pra impressão.

using Exercicio2;

Impressora impressora = new Impressora();

Imprimir imprimir = new Imprimir(impressora);
imprimir.SolicitarTexto();
impressora.SolicitarQuantidadeDeCopias(); 
imprimir.EnviarImpressao();

Console.ReadKey();
