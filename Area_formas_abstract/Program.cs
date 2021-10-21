using System;
using System.Collections.Generic;
using System.Globalization;

namespace Area_formas_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação da lista de formas.
            List<Forma> list = new List<Forma>();
            Console.WriteLine("Entre com o número de formas:");
            int n = int.Parse(Console.ReadLine());
            //Inicio do programa(indicando as formas e suas devidas perguntas).
            for(int i = 1; i <= n; i++)
            {
                //Demonstrando qual forma está.
                Console.WriteLine($"Forma#{i}");
                //Obtendo a informação se a mesma é Retângulo ou Circulo.
                Console.WriteLine("Retângulo ou Circulo? (R/C)");
                char ch = char.Parse(Console.ReadLine());
                //Recebendo a cor da mesma.
                Console.WriteLine("Cor: (Preto/Azul/Vermelho/Roxo):");
                Color cor = Enum.Parse<Color>(Console.ReadLine());
                //Se acaso for Retângulo entre aqui.
                if (ch == 'R')
                {
                    //Pegando a largura e altura, junto da cor e adicionando na lista.
                    Console.WriteLine("Largura: ");
                    double Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Altura: ");
                    double Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Retangulo(Largura, Altura, cor));
                }
                //Caso for circulo, pegue o raio e adicionando na lista.
                else
                {
                    Console.WriteLine("Raio: ");
                    double Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circulo(Raio, cor));
                }
            }
            //Passando por todos os itens da lista
            foreach (Forma forma in list)
            {
                //Se acaso o tamanho da lista for exatamente um escreva no singular.
                if (list.Count == 1)
                {
                    Console.WriteLine("Área: ");
                    Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
                }
                //Se acaso o tamanho da lista for maior que um escreva no plural.
                else
                {
                    Console.WriteLine("Áreas: ");
                    Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
