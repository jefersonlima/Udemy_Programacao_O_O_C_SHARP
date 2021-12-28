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
            j.Id = 1;
            j.Nome = "Ty Runner";
            j.Descricao = "Corrida Infinita";
            j.Console = TipoConsole.Outro;
            j.Genero = TipoGenero.Casual;

            Console.WriteLine("Jogo: " + j.Nome);
            Console.ReadKey();
        }
    }
}
