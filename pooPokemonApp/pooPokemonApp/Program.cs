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
                if (resp == 2) {
                    pokedex.ListarPokemons();
                    Console.WriteLine("Digite o codigo do pokémon");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    //pegar o pokémon do player
                    PokemonPlus pPlayer = pokedex.Pokemons[codigo];
                    Random r = new Random();
                    codigo = r.Next(0, pokedex.Pokemons.Count);
                    PokemonPlus pPC = pokedex.Pokemons[codigo];

                    if(pPlayer.Poder >= pPC.Poder)
                    {
                        Console.WriteLine("Seu pokémon escolhido foi: " + pPlayer.Nome + " ele tem: " + pPlayer.Poder + " de poder. \nE seu adversário foi: " + pPC.Nome + " ele tem: " + pPC.Poder + " poder.");
                        Console.WriteLine("Parabens!!!! você ganhou!!");
                    }
                    else
                    {
                        Console.WriteLine("Seu pokémon escolhido foi: " + pPlayer.Nome + " ele tem: " + pPlayer.Poder + " de poder. \nE seu adversário foi: " + pPC.Nome + " ele tem: " + pPC.Poder + " poder.");
                        Console.WriteLine("Que pena!!!! você Perdeu!!");
                    }
                }

                Console.ReadKey();
                Console.Clear();
            }
            Console.ReadKey();
        }

        static int Menu()
        {
            Console.WriteLine("Pokémon --Jogo de batalha");
            Console.WriteLine("0 - Sair do jogo");
            Console.WriteLine("1 - Listar todos os Pokémons da pokédex");
            Console.WriteLine("2 - Batalhar");
            Console.WriteLine("Escolha uma opção: ");
            int resp = Convert.ToInt32(Console.ReadLine());

            return resp;
        }
    }
}
