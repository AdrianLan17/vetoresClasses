using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Paciente: Pessoa
    {
        string[] tipoConsult = new string[10];
        string[] sintomas = new string[10];
        string[] tempoSintomas = new string[10];
        string[] tempCorp = new string[10];
        string[] classifcRisc  = new string[10];
        int i;
        string ope;

        public override void cadastro()
        {

            for (i = 0; i < 10; i++)
            {
                base.cadastro();
                Console.WriteLine("digite se é uma consulta particular ou convenio");
                tipoConsult[i] = Console.ReadLine();
                Console.WriteLine("sintomas que o paciente esta sentindo:");
                sintomas[i] = Console.ReadLine();
                Console.WriteLine("Digite o tempo que o paciente está sentindo esses sintomas:");
                tempoSintomas[i] = Console.ReadLine();
                Console.WriteLine("Digite a temperatura corporal do paciente");
                tempCorp[i] = Console.ReadLine();
                Console.WriteLine("digite a classificaçao de risco do paciente");
                classifcRisc[i] = Console.ReadLine();

                Console.WriteLine("Digite q para sair!!");
                ope= Console.ReadLine();
                if(ope == "q")
                {
                    break;
                }

            }
        }

        



    }
}
