using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon p = new Pokemon();

            p.Nome = "Bulbassauro";
            p.Descricao = "é um pokemon tipo planta...";

            p.ExibirDadosPokemon();

            //teste sobrecarga
            Pokemon p1 = new Pokemon("Pikachu", "é um pokémon do tipo elétrico...");
            p1.ExibirDadosPokemon(true);

            Console.ReadKey();
        }
    }
}
