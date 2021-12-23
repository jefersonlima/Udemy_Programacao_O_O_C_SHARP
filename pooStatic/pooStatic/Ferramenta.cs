using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooStatic
{
    public class Ferramenta
    {
        private static int NextID;
        public Ferramenta(String nome, int durabilidade)
        {
            try
            {
                NextID++;
            }
            catch (Exception)
            {

                NextID = 0;
            }
            this.ID = NextID;
            this.Nome = nome;
            this.Durabilidade = durabilidade;

        }
        public int ID { get; set; }
        public String Nome { get; set; }
        public int Durabilidade { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine("ID: " + this.ID + " - Nome: " + this.Nome + " - Durabilidade: " + this.Durabilidade);
        }
    }
}
