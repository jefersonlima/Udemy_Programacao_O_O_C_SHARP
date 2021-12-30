using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            //Materia m1 = new Materia("Matematica", 5, 7, 5);
            //m1.ExibirDados();

            Console.WriteLine("Controle de Matérias");
            while (op!= 0)
            {
                op = ExibirMenu();
                if(op == 1)
                {//Exibir matérias

                }
                else if(op == 2)
                {//Cadastrar matérias

                }
                else if (op == 3)
                {//Alterar matérias

                }
                else if (op == 4)
                {//Excluir matérias

                }
            }

            Console.ReadKey();
        }

        static int ExibirMenu()
        {
            int op = 1;
            try
            {
                while (op != 0)
                //while (op < 0 && op > 4)
                {
                    Console.WriteLine("1 - Exibir matérias");
                    Console.WriteLine("2 - Cadastrar matérias");
                    Console.WriteLine("3 - Alterar dados das matérias");
                    Console.WriteLine("4 - Excluir dados das matérias");
                    Console.WriteLine("0 - Sair");
                    Console.Write("Opção: ");

                    op = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Opção Inválida!");
                op = 0;
            }
            return op;
        }
    }
}
