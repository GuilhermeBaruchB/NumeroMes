using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string[] nome = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

                Console.WriteLine("Digite o numero do mês desejado: ");

                int i = int.Parse(Console.ReadLine());

                int numeromes = i - 1;

                Console.WriteLine("O nome selecionado foi: " + nome[numeromes]);

                Console.ReadKey();
        }
    }
}
