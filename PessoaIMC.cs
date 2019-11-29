using System;

namespace csharpDia5
{
    public abstract class PessoaIMC : Pessoa
    {
        protected double Peso { get; set;}
        protected double Altura { get; set;}

        public PessoaIMC (string nome, DateTime dataNascimento, double peso, double altura) : base(nome, dataNascimento)
        {            
            Peso = peso;
            Altura = altura;
        }

        public double GetPeso()
        {
            return Peso;
        }
        public double GetAltura()
        {
            return Altura;
        }

        public double CalcularIMC()
        {
            return Peso / Math.Pow(Altura, 2);
        }
        public override string Imprimir()
        {
            string dadosPessoa = base.Imprimir();
            dadosPessoa += $"Peso: {Peso}\n"
            +$"Altura: {Altura}\n";
            return dadosPessoa;
        }
        public abstract string ResultadoIMC();
    }
}