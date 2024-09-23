using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pessoas[] lista = new pessoas[3];

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Digite Seu Nome");

                lista[i].Nome();
                Console.WriteLine("{0}", lista[i].nome);


            }
            Console.ReadKey();
        }
    } 
}
