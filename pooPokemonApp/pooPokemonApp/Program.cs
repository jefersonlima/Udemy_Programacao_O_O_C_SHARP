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

            Console.ReadKey();
        }
    }
}
