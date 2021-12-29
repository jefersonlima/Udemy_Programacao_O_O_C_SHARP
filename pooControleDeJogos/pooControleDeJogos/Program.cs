using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeJogos
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo j = new Jogo();
            try
            {
                Console.Write("Id: ");
                j.Id = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
            
            j.Nome = "Ty Runner";
            j.Descricao = "Corrida Infinita";
            j.Console = TipoConsole.Outro;
            j.Genero = TipoGenero.Casual;

            Console.WriteLine("Jogo: " + j.Nome);
            Console.ReadKey();
        }
    }
}
