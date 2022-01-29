using System;
using System.Globalization;

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
            string[] vetor = Console.ReadLine().Split(' '); // Split - Função que serve para recortar espaço em branco
            string a = vetor[0]; // Acessa posição 0 do array
            string b = vetor[1]; // Acessa posição 1 do array
            string c = vetor[2]; // Acessa posição 2 do array

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadLine();
        }

        public void Exemplo02()
        {

            // ReadLine - ler dados do tipo string, então precisa converter os tipos. 
            int n1 = int.Parse(Console.ReadLine()); // Ler número inteiro
            char ch = char.Parse(Console.ReadLine()); // Ler caracter tipo char
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Ler número tipo double

            string[] vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }

        public void Exercicio()
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int bedrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrar preço do produto: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vect = Console.ReadLine().Split(' ');
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string lastName = vect[0];
            int age = int.Parse(vect[1]);
            double height = double.Parse(vect[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(fullName);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height);

            Console.ReadLine();
        }
    }
}
