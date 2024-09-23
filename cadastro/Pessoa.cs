using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pessoa
        
    {
        string[] nome = new string[10];
        string[] cpf = new string[10];
        string[] numeroTel = new string[10];
        string[] email = new string[10];
        string[] dataNasc = new string[10];
        string[] cep = new string[10];
        string[] rua = new string[10];
        string[] bairro = new string[10];
        string[] cidade = new string[10];
        int[] numeroCasa = new int[10];
        int[] idade = new int[10];
        int i;
        public virtual void cadastro()
        {
                    Console.WriteLine("CADASTRO!\n");
                    Console.WriteLine("Digite o nome do pasciente:");
                    this.nome[i] = Console.ReadLine();
                    Console.WriteLine("digite seu cpf");
                    this.cpf[i] = Console.ReadLine();
                    Console.WriteLine("digite seu numero de telefone");
                    this.numeroTel[i] = Console.ReadLine();
                    Console.WriteLine("digite seu email");
                    this.email[i] = Console.ReadLine();
                    Console.WriteLine("digite sua data de nascimento");
                    this.dataNasc[i] = Console.ReadLine();
                    Console.WriteLine("digite a sua idade");
                    this.idade[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite seu cep");
                    this.cep[i] = Console.ReadLine();  
                    Console.WriteLine("digite o nome da sua rua");
                    this.rua[i] = Console.ReadLine();
                    Console.WriteLine("digite o nome do seu bairro");
                    this.bairro[i] = Console.ReadLine();
                    Console.WriteLine("digite o nome da sua cidade");
                    this.cidade[i] = Console.ReadLine();
                    Console.WriteLine("digite o numero da casa");
                    this.numeroCasa[i]= int.Parse(Console.ReadLine());
        
                      

                

            
        }
      
    }
}
