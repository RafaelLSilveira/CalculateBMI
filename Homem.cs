using System;

namespace csharpDia5
{
    public class Homem : PessoaIMC
    {
        
        public Homem(string nome, DateTime dataNascimento, double peso, double altura) : base(nome, dataNascimento, peso, altura)
        {
        }

        public override string ResultadoIMC()
        {
            double imc = CalcularIMC();
            return imc < 20.7 ? "Abaixo do peso ideal" : (imc >= 20.7 && imc < 26.4) ? "Peso ideal" : "Acima do peso ideal";
        }
    }
}