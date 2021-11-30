using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maiorIdade
{

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();
            Pessoa pessoa3 = new Pessoa();

            Console.Write("Informe o nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Informe o ano de nascimento: ");
            pessoa1.AnoNascimento = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Informe o ano de nascimento: ");
            pessoa2.AnoNascimento = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o nome: ");
            pessoa3.Nome = Console.ReadLine();
            Console.Write("Informe o ano de nascimento: ");
            pessoa3.AnoNascimento = Convert.ToInt32(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade && pessoa1.Idade > pessoa3.Idade)
            {
                pessoa1.ExibirDados();
            }else if (pessoa2.Idade > pessoa1.Idade && pessoa2.Idade > pessoa3.Idade)
            {
                pessoa2.ExibirDados();
            }
            else
            {
                pessoa3.ExibirDados();
            }

            //if (pessoa1.Idade >= 18)
            //{
            //    Console.WriteLine("é de Maior");
            //}
            //else
            //{
            //    Console.WriteLine("Não é de Maior");
            //}

            Console.ReadKey();
        }
    }
}
