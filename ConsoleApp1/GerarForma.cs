namespace ConsoleApp1

{
    internal class GerarForma
    {

        public void SolicitarForma()
        {
            int opcao = 0;

            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Quadrado");
                Console.WriteLine("2 - Triangulo");
                Console.WriteLine("3 - Circunferencia");
                Console.WriteLine("4 - Hexagono");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("");

                Console.Write("A Opção escolhida é: ");
                opcao = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Quadrado quad = new Quadrado();
                        Console.Write("Digite o Lado: ");
                        quad.LadoQA = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        quad.CalcularArea();
                        Console.WriteLine($"A area do Quadrado é {quad.Area}");
                        quad.CalcularPerimetro();
                        Console.WriteLine($"O perímetro do Quadrado é {quad.Perimetro}");
                        Console.WriteLine("");

                        break;

                    case 2:
                        Triangulo tri = new Triangulo();
                        Console.Write("Digite o lado A do triangulo: ");
                        tri.LadoA = double.Parse(Console.ReadLine());
                        Console.Write("Digite o lado B do triangulo: ");
                        tri.LadoB = double.Parse(Console.ReadLine());
                        Console.Write("Digite o lado C do triangulo: ");
                        tri.LadoC = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        tri.CalcularArea();
                        Console.WriteLine($"A area do triangulo é {tri.Area}");
                        tri.CalcularPerimetro();
                        Console.WriteLine($"O perimetro do triangulo é {tri.Perimetro}");
                        Console.WriteLine("");

                        break;

                    case 3:
                        Circunferencia circ = new Circunferencia();
                        Console.Write("Digite o raio da circuferencia: ");
                        circ.raio = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        circ.CalcularArea();
                        Console.WriteLine($"A area da circuferencia é {circ.Area}");
                        circ.CalcularPerimetro();
                        Console.WriteLine($"O perimetro da circuferencia é {circ.Perimetro}");
                        Console.WriteLine("");

                        break;

                    case 4:
                        Hexagono hex = new Hexagono();
                        Console.Write("Digite o lado do hexagono: ");
                        hex.LadoH1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        hex.CalcularArea();
                        Console.WriteLine($"A area do hexagono é {hex.Area}");
                        hex.CalcularPerimetro();
                        Console.WriteLine($"O perimetro do hexagono é {hex.Perimetro}");
                        Console.WriteLine("");

                        break;

                    case 5:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine("");
                        break;

                }

            } while (opcao != 5);
        }
    }
}

         