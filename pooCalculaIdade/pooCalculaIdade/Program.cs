using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a Idade de uma pessoa");
            
            Console.WriteLine("Nome da Pessoa: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Ano de nascimento: ");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());

            Pessoa p = new Pessoa(nome, anoNascimento);
            Console.WriteLine(p.Idade);
            p.ExibirDados();
            Console.ReadKey();
        }
    }
}
