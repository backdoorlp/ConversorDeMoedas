using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double qtdreal, qtddolar, valordolar, convertidoreal, convertidodolar;
            int op;

            Console.WriteLine("Conversor de moedas");
            Console.WriteLine("Digite {1} para converter Real em Dolar, Digite {2} Para converter Dolar em Real ");
            op = Convert.ToInt32(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Quanto esta valendo o dolar");
                valordolar = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual Quantia em Real voce deseja Converter?");
                qtdreal = double.Parse(Console.ReadLine());

                convertidoreal = qtdreal / valordolar;

                Console.WriteLine("A Conversão de R$" + qtdreal + " é: " + "$" + convertidoreal);
            }
            else if (op == 2)
            {
                Console.WriteLine("Quanto esta Valendo o dolar: ");
                valordolar = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual Quantia em dolares voce deseja converter: ");
                qtddolar = double.Parse(Console.ReadLine());

                convertidodolar = qtddolar * valordolar;

                Console.WriteLine("A Conversão de $" + qtddolar + " é: " + "R$" + convertidodolar);
            }
            else
            {
                Console.WriteLine("Você Não Selecionou Uma Opção Válida!!");
            }

            Console.ReadKey();
        }
    }
}