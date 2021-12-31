using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeArtes
{
    public class Arte : IArte
    {
        public Arte()
        {
            this.Nome = "";
            this.Descricao = "";
        }
        public Arte(String nome, String descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

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

        public void ExibirDados()
        {
            //Console.WriteLine("Arte: " + this.Nome + " Descrição: " + this.Descricao);
            Console.WriteLine("Arte: {0} - Descrição: {1}", this.Nome, this.Descricao);
        }
    }
}
