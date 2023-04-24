namespace Exercicio2

{
    class Imprimir
    {
        private Impressora impressora;

        public Imprimir(Impressora impressora)
        {
            this.impressora = impressora;
        }
        public void SolicitarTexto()
        {
            Console.WriteLine("Digite o texto a ser impresso: ");
            Documento documento = new Documento();
            documento.Texto = Console.ReadLine();
            impressora.SetDocumento(documento);
        }

        public void EnviarImpressao()
        {
            impressora.Imprimir();
        }
    }
}