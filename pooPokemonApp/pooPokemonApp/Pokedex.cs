using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class Pokedex
    {
        #region Construtor
        public Pokedex()
        {
            this.InicializaLista();
        }
        #endregion

        #region Atributos
        private List<PokemonPlus> pokemons;

        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }
        #endregion

        #region Metodos
        private void InicializaLista()
        {
            //instanciar a lista
            this.pokemons = new List<PokemonPlus>();

            //instancia um objeto
            PokemonPlus p = new PokemonPlus("Bulbasauro", "pokémon tipo planta", 100);
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new PokemonPlus("Mew", "lendario psiquico", 90);
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new PokemonPlus("Giratina", "lendario Fantasma", 50);
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new PokemonPlus("Flygon", "pokémon Dragão", 60);
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new PokemonPlus("Metagross", "pokémon de metal", 110);
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new PokemonPlus("Muk", "pokémon de metal", 80);
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new PokemonPlus("Metagross", "pokémon tóxico", 75);
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new PokemonPlus("Metagross", "pokémon tóxico", 42);
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new PokemonPlus("Lucario", "pokémon tóxico", 12);
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new PokemonPlus("Mudkip", "pokémon de agua", 67);
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new PokemonPlus("Paras", "pokémon inseto", 83);
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new PokemonPlus("Kyogre", "pokémon da agua", 91);
            //adiciona o objeto na lista
            this.pokemons.Add(p);
        }

        public void ListarPokemons()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {   
                //Jeito 1
                //Pokemon p = this.Pokemons[i];
                //p.ExibirDadosPokemon();

                //Jeito 2
                this.Pokemons[i].ExibirDadosPokemon();
            }
        }

        #endregion
    }
}
