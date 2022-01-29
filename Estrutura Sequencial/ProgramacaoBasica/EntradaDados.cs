using System;

namespace ProgramacaoBasica
{
    /*
     Comando que ler - Console.ReadLine()/
     */
    class EntradaDados
    {
        public void Exemplo01()
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            // Vetor tipo string
            string[] v = Console.ReadLine().Split(' '); // Split - Função que serve para recortar espaço em branco
            string a = v[0]; // Acessa posição 0 do array
            string b = v[1]; // Acessa posição 1 do array
            string c = v[2]; // Acessa posição 2 do array
            
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
