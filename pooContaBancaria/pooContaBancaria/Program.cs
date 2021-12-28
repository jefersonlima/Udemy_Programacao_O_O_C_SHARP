using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaBancaria conta = new ContaBancaria();
            //conta.Depositar(600);
            //conta.Correntista.Nome = "Jeferson Lima";

            ContaEstudante conta = new ContaEstudante();
            conta.Correntista.Nome = "Jeferson Lima";
            int menu = 1;

            while (menu != 0)
            {
                Console.WriteLine("Menu de opções");
                Console.WriteLine("1 - Exibir dados do correntista");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Retirar");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    conta.ExibirDadosBancarios();
                }
                else if (menu == 2)
                {
                    try
                    {
                        Console.Write("Valor para Deposito: ");
                        Double valor = Convert.ToDouble(Console.ReadLine());
                        conta.Depositar(valor);
                        Console.WriteLine("Saldo atual: " + conta.Saldo);

                    }
                    catch (Exception erro)
                    {

                        Console.WriteLine("Ops!!! Algo deu errado.");
                        Console.WriteLine("Erro: " + erro.Message);
                    }
                }
                else if (menu == 3)
                {
                    try
                    {
                        Console.Write("Valor para retirada: ");
                        Double valor = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Saldo restante: " + conta.Retirar(valor));

                    }
                    catch (Exception erro)
                    {

                        Console.WriteLine("Ops!!! Algo deu errado.");
                        Console.WriteLine("Erro: " + erro.Message);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
