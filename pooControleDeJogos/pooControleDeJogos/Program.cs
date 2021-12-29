using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeJogos
{
    class Program
    {
        static int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Controle de Jogos ===");
            Console.WriteLine("[1] Cadastrar um jogo");
            Console.WriteLine("[2] Excluir um jogo");
            Console.WriteLine("[3] Alterar um jogo");
            Console.WriteLine("[4] Localizar um jogo por nome");
            Console.WriteLine("[5] Listar os jogos por Gênero");
            Console.WriteLine("[6] Listar os jogos por console");
            Console.WriteLine("[7] Listar todos os jogos");
            Console.WriteLine("[0] Sair");
            Console.Write("Opção: ");
            int opcao;
            try
            {
                opcao = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Opção Inválida!");
                opcao = 0;
            }

            return opcao;
        }
        static void Main(string[] args)
        {
            ListaDeJogos listaDeJogos = new ListaDeJogos();
            List<Jogo> lista;
            Jogo jogo;

            jogo = new Jogo(1, "Ty Runner", "Corrida infinita", TipoGenero.Aventura, TipoConsole.Outro);
            listaDeJogos.Inserir(jogo);
            jogo = new Jogo(2, "Jackpot", "Caça-níquel", TipoGenero.Casual, TipoConsole.Outro);
            listaDeJogos.Inserir(jogo);
            jogo = new Jogo(3, "Faroeste Zumbi", "Jogo de tiro", TipoGenero.Acao, TipoConsole.PC);
            listaDeJogos.Inserir(jogo);

            int opcao = 1;

            while (opcao != 0)
            {
                opcao = ShowMenu();

                switch (opcao)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:
                        Console.WriteLine("Localizar Jogos");
                        Console.Write("Informe o nome do Jogo: ");
                        String nomeJogo;
                        try
                        {
                            nomeJogo = Console.ReadLine();
                        }
                        catch (Exception)
                        {

                            Console.Write("Opção Inválida!");
                            break;
                        }
                        lista = listaDeJogos.Localizar(nomeJogo);

                        foreach (var j in lista)
                        {
                            Console.Write("ID: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descrição: " + j.Descricao);
                            Console.Write(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para sair");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Listar todos os jogos por Gênero"); 
                        Console.Write("Informe o Console Ação [0], Aventura [1], Casual [2], Puzze [3], Estratégia [4], Outro [5]: ");
                        TipoGenero genero;
                        try
                        {
                            genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {

                            Console.Write("Opção Inválida!");
                            break;
                        }
                        lista = listaDeJogos.ListarPorGenero(genero);

                        foreach (var j in lista)
                        {
                            Console.Write("ID: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descrição: " + j.Descricao);
                            Console.Write(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para sair");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("Listar todos os jogos por Console");
                        Console.Write("Informe o Console Ps4 [0], Ps5 [1], Switch [2], Xbox 360 [3], Xbox One [4], PC [5], Outro [6]: ");
                        TipoConsole console;
                        try
                        {
                            console = (TipoConsole)Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {

                            Console.Write("Opção Inválida!");
                            break;
                        }
                        lista = listaDeJogos.ListarPorConsole(console);

                        foreach (var j in lista)
                        {
                            Console.Write("ID: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descrição: " + j.Descricao);
                            Console.Write(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para sair");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Listar todos os jogos");
                        foreach (var j in listaDeJogos.Jogos)
                        {
                            Console.Write("ID: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descrição: " + j.Descricao);
                            Console.Write(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para sair");
                        Console.ReadKey();
                        break;
                }
            }
            
            //Jogo j = new Jogo();
            //try
            //{
            //    Console.Write("Id: ");
            //    j.Id = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception erro)
            //{
            //    Console.WriteLine(erro.Message);
            //}
            
            //j.Nome = "Ty Runner";
            //j.Descricao = "Corrida Infinita";
            //j.Console = TipoConsole.Outro;
            //j.Genero = TipoGenero.Casual;

            //Console.WriteLine("Jogo: " + j.Nome);
            //Console.ReadKey();
        }
    }
}
