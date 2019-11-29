using System;

namespace csharpDia5
{
    class Mulher : PessoaIMC
    {
        public Mulher(string nome, DateTime dataNascimento, double peso, double altura) : base(nome, dataNascimento, peso, altura)
        {
        }

        public override string ResultadoIMC()
        {
            double imc = CalcularIMC();
            return imc < 19 ? "Abaixo do peso ideal" : (imc >= 19 && imc < 25.8) ? "Peso ideal" : "Acima do peso ideal";
        }
    }
}