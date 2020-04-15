using System;

namespace csharpDia5
{
    class Programa : Menu
    {
        public Pessoa Pessoa;
        public void Executar()
        {
            string nomePessoa = "";
            DateTime dataNascimento = new DateTime();
            double peso = 0;
            double altura = 0;

            Escrever("##################  CÁLCULO DE IMC ###################");

            Escrever("\nDigite seu Nome: ");
            nomePessoa = Ler();

            Escrever("Digite sua Data de Nascimento: (aaaa-MM-dd) ");
            dataNascimento = DateTime.Parse(Ler());

            Escrever("Digite sua Altura: (ex: 1.50)");
            altura = double.Parse(Ler());

            Escrever("Digite sue Peso: (ex: 82.4)");
            peso = double.Parse(Ler());

            PessoaIMC pessoa;

            Escrever("Qual seu sexo ? (m = masculino,f=feminino)");
            if (Console.ReadKey().Key.Equals(ConsoleKey.M))
            {
                pessoa = new Homem(nomePessoa, dataNascimento,peso,altura);
            }
            else
            {
                pessoa = new Mulher(nomePessoa, dataNascimento,peso,altura);
            }

            // Limpa Tela para Mostrar melhor as Informações
            LimparTela();
            // Gera informações da Pessoa
            Escrever(pessoa.Imprimir());
            // Gera o IMC da Pessoa
            Escrever($"IMC : {pessoa.ResultadoIMC()}");
            SegurarTela();
        }
    }
           
}