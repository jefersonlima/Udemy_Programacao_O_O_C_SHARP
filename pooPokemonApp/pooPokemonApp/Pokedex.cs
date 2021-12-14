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
        private List<Pokemon> pokemons;

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
        }
        #endregion
        #region Metodos
        private void InicializaLista()
        {
            //instanciar a lista
            this.pokemons = new List<Pokemon>();

            //instancia um objeto
            Pokemon p = new Pokemon("Bulbasauro", "pokémon tipo planta");
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new Pokemon("Mew", "lendario psiquico");
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new Pokemon("Giratina", "lendario Fantasma");
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new Pokemon("Flygon", "pokémon Dragão");
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new Pokemon("Metagross", "pokémon de metal");
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new Pokemon("Muk", "pokémon de metal");
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new Pokemon("Metagross", "pokémon tóxico");
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new Pokemon("Metagross", "pokémon tóxico");
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new Pokemon("Lucario", "pokémon tóxico");
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new Pokemon("Mudkip", "pokémon de agua");
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new Pokemon("Paras", "pokémon inseto");
            //adiciona o objeto na lista
            this.pokemons.Add(p);

            p = new Pokemon("Kyogre", "pokémon da agua");
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
