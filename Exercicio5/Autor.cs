﻿namespace Exercicio5
{
    public class Autor
    {
    public string Nome { get; set; }
    public string PaisOrigem { get; set; }
    public DateTime DataNascimento { get; set; }
    public string IdiomaNativo { get; set; }


    public Autor(string nomeautor, string paisorigemautor, DateTime datanascimentoautor, string idiomaautor)
        {
        Nome = nomeautor;
        PaisOrigem = paisorigemautor;
        DataNascimento = datanascimentoautor;
        IdiomaNativo = idiomaautor;
        }


    }
}