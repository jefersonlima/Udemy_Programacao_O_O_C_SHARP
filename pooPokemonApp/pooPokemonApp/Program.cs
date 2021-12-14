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
            //Pokemon p = new Pokemon();

            //p.Nome = "Bulbassauro";
            //p.Descricao = "é um pokemon tipo planta...";

            //p.ExibirDadosPokemon();

            ////teste sobrecarga
            //Pokemon p1 = new Pokemon("Pikachu", "é um pokémon do tipo elétrico...");
            //p1.ExibirDadosPokemon(true);

            //Pokedex pokedex = new Pokedex();
            //Pokemon p = pokedex.Pokemons[1];

            //p.ExibirDadosPokemon();

            //Pokedex pokedex = new Pokedex();
            //pokedex.ListarPokemons();

            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while (resp != 0)
            {
                resp = Menu();
                if (resp == 1)
                {
                    pokedex.ListarPokemons();
                }
                Console.ReadKey();
                Console.Clear();
            }
            Console.ReadKey();
        }

        static int Menu()
        {
            Console.WriteLine("Pokédex ---- Agenda Pokémon");
            Console.WriteLine("0 - Sair da Pokédex");
            Console.WriteLine("1 - Listar todos os Pokémons");
            Console.WriteLine("Escolha uma opção: ");
            int resp = Convert.ToInt32(Console.ReadLine());

            return resp;
        }
    }
}
