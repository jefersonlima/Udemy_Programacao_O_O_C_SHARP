using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeNotas
{
    public class Aluno : InterfaceAluno
    {
        public Aluno()
        {
            this.Nome = "";
            this.Email = "";
        }

        public Aluno(String nome, String email)
        {
            this.Nome = nome;
            this.Email = email;
        }

        private String nome;
        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        private String email;

        public String Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public void ExibirDados()
        {
            Console.WriteLine("Dados do Aluno");
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Email: " + this.Email);
        }
    }
}
