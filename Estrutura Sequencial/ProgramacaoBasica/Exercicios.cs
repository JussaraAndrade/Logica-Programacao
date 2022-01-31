using System;
using System.Globalization;

namespace ProgramacaoBasica
{
    class Exercicios
    {
        public void CalculoAreaTerreno()
        {
            double largura, comprimento, precoMetroQuadrado, area, preco;

            Console.WriteLine("Digite a largura: ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a comprimento: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a preço metro quadrado: ");
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            area = largura * comprimento;  
            preco = area * precoMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
