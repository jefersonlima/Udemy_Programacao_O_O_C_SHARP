using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RacingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "s";
            Boolean ganhou = false;
            int aposta = 0, ganhador = 0;
            

            while (resp == "s")
            {
                Pista p1 = new Pista(100, new Corredor("j"));
                Pista p2 = new Pista(100, new Corredor("d"));
                Pista p3 = new Pista(100, new Corredor("n"));
                Pista p4 = new Pista(100, new Corredor("l"));
                Pista p5 = new Pista(100, new Corredor("m"));

                

                Console.Clear();
                Console.WriteLine("$#@ - Corrida Maluca - @#$");
                Console.WriteLine("Corredores \n1 - Jeferson(j)\n2 - Denise(d)\n3 - Nickolas(n)\n4 - Luiz(l)\n5 - Maria(m)");
                Console.Write("Em qual corredor você aposta (1, 2, 3, 4, ou 5: ");

                aposta = Convert.ToInt32(Console.ReadLine());
                ganhador = 0;
                ganhou = false;

                while (ganhou == false)
                {
                    Console.Clear();
                    if (p1.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 1;
                    }
                    if (p2.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 2;
                    }
                    if (p3.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 3;
                    }
                    if (p4.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 4;
                    }
                    if (p5.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 5;
                    }

                    p1.ExibirPista();
                    p2.ExibirPista();
                    p3.ExibirPista();
                    p4.ExibirPista();
                    p5.ExibirPista();
                    Thread.Sleep(400);
                }

                Console.Clear();
                Console.WriteLine("$#@ - Corrida Maluca - @#$");
                Console.WriteLine($"O ganhador foi o corredor de número {ganhador}");
                switch (ganhador)
                {
                    case 1:
                        Console.WriteLine("Jeferson");
                        break;
                    case 2:
                        Console.WriteLine("Denise");
                        break;
                    case 3:
                        Console.WriteLine("Nickolas");
                        break;
                    case 4:
                        Console.WriteLine("Luiz");
                        break;
                    case 5:
                        Console.WriteLine("Maria");
                        break;
                }
                if (ganhador == aposta)
                {
                    Console.WriteLine("Parabens, você venceu a aposta");
                }
                else
                {
                    Console.WriteLine("que pena, você perdeu a aposta");
                }
                Console.WriteLine();
                Console.WriteLine("Deseja jogar novamente?");
                resp = Console.ReadLine().ToLower();
            }
        }
    }
}
