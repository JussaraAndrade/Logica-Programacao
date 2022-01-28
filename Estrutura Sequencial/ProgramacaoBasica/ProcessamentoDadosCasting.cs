using System;

namespace ProgramacaoBasica
{
    /*
        Processamento de dados
        
        <variável> = <expressão>

        Atribuição - variável recebe e armazena o resultado da expressão
        
     */
    class ProcessamentoDadosCasting
    {
        public void Exemplo01()
        {
            int x, y;
            x = 5;
            y = 2 * x;

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.ReadLine();
        }

        public void Exemplo02()
        {
            int x;
            double y;
            x = 5;
            y = 2 * x;

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.ReadLine();
        }

        public void AreaTrapeziosDouble()
        {
            double b, B, h, area;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;

            Console.WriteLine(area);
            Console.ReadLine();
        }

        public void AreaTrapeziosFloat()
        {
            float b, B, h, area;

            b = 6.0f;
            B = 8.0f;
            h = 5.0f;

            area = (b + B) / 2f * h;

            Console.WriteLine(area);
            Console.ReadLine();
        }

        public void ConversaoCastingDouble()
        {
            int a, b;
            double resultado;

            a = 5;
            b = 2;

            resultado = (double) a / b;
            Console.WriteLine(resultado);
            Console.ReadLine();
        }

        public void ConversaoCastingInt()
        {
            double a;
            int b;

            a = 5.0;
            b = (int)a;  

            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
