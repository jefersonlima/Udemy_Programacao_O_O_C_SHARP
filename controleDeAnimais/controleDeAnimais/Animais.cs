using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDeAnimais
{
     public class Animais
    {
        #region Construtor
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
        private String tipo;

        public String Tipo
        {
            get { return tipo; }
            set
            {
                if (value == "Cachorro" || value == "Gato" || value == "Peixe")
                {
                    tipo = value;
                }
                else
                {
                    tipo = "Peixe";
                }
            }
        }
        #endregion
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

        //#region Métodos
        //public void quantidadeAnimais()
        //{
        //    Console.WriteLine("Quantidade de Cachorros: " + this.quantidadeCachorros);
        //    Console.WriteLine("Quantidade de Gatos: " + this.quantidadeGatos);
        //    Console.WriteLine("Quantidade de Peixes: " + this.quantidadePeixes);
        //}
        //#endregion
    }
}
