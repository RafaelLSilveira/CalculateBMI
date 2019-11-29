using System;

namespace csharpDia5
{
    public class Pessoa
    {
        protected string Nome { get; set; }
        protected DateTime DataNascimento { get; set; }

        public Pessoa (string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public virtual string Imprimir()
        {
            string informacoes = $"\nNome: {Nome}\n"
             + $"Data de Nascimento: {DataNascimento.ToLongDateString()} \n"
             + $"Idade: {DateTime.Now.Date.Year - int.Parse(DataNascimento.Year.ToString())}\n";
            return informacoes;
        }

    }
}