using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class Pokemon
    {
        #region Construtor
        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }
        //Sobrecarga de Metodos
        public Pokemon(String nome, String descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }
        #endregion

        #region Atributos Pokemons
        private String nome;

        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        private String descricao;

        public String Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value.ToUpper(); }
        }
        #endregion

        #region Metodos
        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome do Pokémon: " + this.Nome);
            Console.WriteLine("Descrição do Pokémon: " + this.Nome + " " + this.Descricao);
        }

        public void ExibirDadosPokemon(Boolean formatado)
        {
            if (formatado == true)
            {
                Console.WriteLine("Pokémon " + this.Nome + ": " + this.Descricao.ToLower());
            }
            else
            {
                Console.WriteLine("Nome do Pokémon: " + this.Nome);
                Console.WriteLine("Descrição do Pokémon: " + this.Nome + " " + this.Descricao);
            }
        }
        #endregion
    }
}
