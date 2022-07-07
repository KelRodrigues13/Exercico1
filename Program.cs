using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico1
{
    internal class Program
    {
        static void Main(string[] args) {
            double trabalho, prova1, prova2, nota;

            Console.WriteLine("Digite a nota do Trabalho");
            trabalho = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da Prova 1");
            prova1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da Prova 2");
            prova2 = double.Parse(Console.ReadLine());


            nota = (2 * trabalho + 3 * prova1 + 5 * prova2) / 10;
            Console.WriteLine("Media = " + nota);

            if (nota >= 8.5) {
                Console.WriteLine("Media A");
            } else if (nota >= 7.0) {
                Console.WriteLine("Media B");
            } else if (nota >= 6.0) {
                Console.WriteLine("Media C");
            } else if (nota >= 0.1) {
                Console.WriteLine("Media D");
            } else if (nota >= 0.0) {
                Console.WriteLine("Media E");
            }




            Console.ReadKey();
        }
    }
}
