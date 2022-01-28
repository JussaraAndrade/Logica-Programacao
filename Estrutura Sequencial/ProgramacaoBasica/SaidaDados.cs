using System;
using System.Globalization;

namespace ProgramacaoBasica
{
    class SaidaDados
    {
        public void Input()
        {
            Console.Write("Olá mundo");
            Console.WriteLine("Bom dia!"); // Quebra de linha
            Console.WriteLine("Até mais."); // Quebra de linha

            Console.ReadLine();
        }

        public void PontoFluturante()
        {
            double x = 10.35784;

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2")); // Duas casas decimais
            Console.WriteLine(x.ToString("F4")); // Quatro casas decimais

            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }

        public void ConcatenaVariosElementos()
        {
            double x = 10.35784;

            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.WriteLine();
            Console.WriteLine("RESULTADO: " + x);
            Console.WriteLine("O valor do troco é: " + x + " reais");
            Console.WriteLine("O valor do troco é: " + x.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

            Console.ReadLine();
        }
    }
}
