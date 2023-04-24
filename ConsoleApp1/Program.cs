// Exercicio05
//Crie um software para controlar o cálculo da área e perímetro de objetos geométricos de acordo com diagrama a seguir.
//Existe um relacionamento de herança entre as classes Circunferência, Triangulo, Quadrado com a classe Forma.
//Os métodos CalcularArea() e CalcularPerimetro() na classe Forma serão do tipo virtuais, pois poderão ser sobreposto(polimorfismo) nas classes filhas.
//A classe GerarForma por meio do método SolicitarForma(), apresentará na tela uma informação solicitando o tipo de objeto que será gerado e de acordo com tipo será solicitado os Lados e mostrará na tela o resultado dos cálculos da área e perímetro.
//Adicione uma classe o objeto geométrico Hexágono e implemente seus métodos.
//A classe Program, irá instanciar a classe GerarForma

using ConsoleApp1;

GerarForma gerarForma = new GerarForma();
gerarForma.SolicitarForma();


