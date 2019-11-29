using System;

namespace csharpDia5
{
    class Menu
    {

        public string Ler()
        {
            return Console.ReadLine();
        }
        public void Escrever(String dado)
        {
            Console.WriteLine($"{dado}");
        }
        public void LimparTela()
        {
            Console.Clear();
        }
        public void SegurarTela()
        {
            Console.ReadKey();
        }
    }


}