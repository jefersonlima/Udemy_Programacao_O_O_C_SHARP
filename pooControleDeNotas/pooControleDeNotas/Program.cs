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
            int op = 0;
            String NomeMateria = "";
            Double n1 = 0, n2 = 0, mo = 5;
            Materia materia;

            GerenciadorDeMaterias gm = new GerenciadorDeMaterias("Jeferson", "jeferson@gmail.com");
                     
            while (op!= 5)
            {
                Console.WriteLine("Controle de Matérias");
                gm.Estudante.ExibirDados();
                op = ExibirMenu();
                Console.Clear();
                if (op == 1)
                {//Exibir matérias
                    gm.ListarMaterias();
                }
                else if (op == 2)
                {//Cadastrar matérias
                    Console.WriteLine("Cadastro de Matérias");
                    Console.Write("Materia: ");
                    NomeMateria = Console.ReadLine();
                    Console.Write("1º nota: ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2º nota: ");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    materia = new Materia(NomeMateria, n1, n2, mo);
                    gm.CadastrarMaterias(materia);
                }
                else if (op == 3)
                {//Alterar matérias

                }
                else if (op == 4)
                {//Excluir matérias

                }
                Console.ReadKey();
            }
            Console.ReadKey();
        }

        static int ExibirMenu()
        {
            int op = 0;
            try
            {
                //while (op != 0)
                while (op < 1 || op > 5
                    )
                {
                    Console.WriteLine("1 - Exibir matérias");
                    Console.WriteLine("2 - Cadastrar matérias");
                    Console.WriteLine("3 - Alterar dados das matérias");
                    Console.WriteLine("4 - Excluir dados das matérias");
                    Console.WriteLine("5 - Sair");
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
