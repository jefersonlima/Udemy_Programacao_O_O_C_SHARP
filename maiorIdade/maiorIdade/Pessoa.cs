using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maiorIdade
{
    class Pessoa
    {
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private int anoNascimento;

        public int AnoNascimento
        {
            get { return anoNascimento; }
            set { anoNascimento = value; }
        }

        private int idade;

        public int Idade
        {
            get {
                this.CalcularIdade();
                return idade; }
         
        }

        public void CalcularIdade()
        {
            DateTime dataAtual = DateTime.Now;
            int ano = dataAtual.Year;

            this.idade = ano - this.anoNascimento;
        }

        public void ExibirDados()
        {
            Console.WriteLine("Pessoa mais Velha!");
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Idade: " + this.idade);

        }



    }
}
