using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDeAnimais
{
     public enum TipoAnimal { Cachorro, Gato, Peixe }
     public class Animais
    {
        #region Construtor
        public Animais()
        {
            this.Nome = "";
            this.Tipo = TipoAnimal.Peixe;
        }

        public Animais(String nome, TipoAnimal tipo)
        {
            this.Nome = nome;
            this.Tipo = tipo;
        }
        //public Animais(String nomeAnimal, String tipoAnimal)
        //{
        //    this.nome = nomeAnimal;
        //    if (tipoAnimal == "Cachorro" || tipoAnimal == "Gato" || tipoAnimal == "Peixe")
        //    {
        //        tipo = tipoAnimal;
        //    }
        //    else
        //    {
        //        tipo = "Peixe";
        //    }
        //}
        #endregion

        #region Atributos
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }
        private TipoAnimal tipo;

        public TipoAnimal Tipo
        {
            get { return tipo; }
            set { this.tipo = value; }           
        }

        //public int quantidadeCachorros
        //{
        //    get;
        //    set;
        //}

        //public int quantidadeGatos
        //{
        //    get;
        //    set;
        //}

        //public int quantidadePeixes
        //{
        //    get;
        //    set;
        //}
        //
        #endregion

        #region Métodos
        //public void quantidadeAnimais()
        //{
        //    Console.WriteLine("Quantidade de Cachorros: " + this.quantidadeCachorros);
        //    Console.WriteLine("Quantidade de Gatos: " + this.quantidadeGatos);
        //    Console.WriteLine("Quantidade de Peixes: " + this.quantidadePeixes);
        //}
        #endregion
    }
}
