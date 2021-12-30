using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeNotas
{
    public class Materia : ModeloMateria
    {
        public Materia()
        {
            this.Nome = "";
            this.Nota1 = 0;
            this.Nota2 = 0;
            this.MediaAprovacao = 5;

        }
        public Materia(String nome, Double nota1, Double nota2, Double mediaAprovacao)
        {
            this.Nome = nome;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.MediaAprovacao = mediaAprovacao;
        }
        public Double MediaAprovacao { get; set; }

        public Double Media 
        {
            get
            {
                return (this.Nota1 + this.Nota2) / 2;
            }
                
        }
        public override void ExibirDados()
        {
            Console.WriteLine("Materia: " + this.Nome);
            Console.WriteLine("1º Nota: " + this.Nota1);
            Console.WriteLine("2º Nota: " + this.Nota2);
            Console.WriteLine("Media: " + this.Media);
            Console.WriteLine("Media para Aprovação: " + this.MediaAprovacao);
            Console.WriteLine("Status da materia: " + this.StatusMateria());
        }
        private string StatusMateria()
        {
            String msg = "Aluno não aprovado na materia";
            if (this.Media >= this.MediaAprovacao)
            {
                msg = "Aluno aprovado na materia";
            }
            return msg;
        }
    }
}
