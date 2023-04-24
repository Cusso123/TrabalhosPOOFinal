namespace Exercicio2
{
    class Impressora
    {
        private Documento documento;
        public int QtdDeCopia { get; set; }

        public Impressora()
        {
            this.QtdDeCopia = 1;
        }

        public void SolicitarQuantidadeDeCopias()
        {
            Console.Write("Digite a quantidade de cópias: ");
            QtdDeCopia = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        public void Imprimir()
        {
            for (int i = 0; i < QtdDeCopia; i++)
            {
                Console.WriteLine(documento.Texto);
            }
        }

        public void SetDocumento(Documento documento)
        {
            this.documento = documento;
        }
    }
}