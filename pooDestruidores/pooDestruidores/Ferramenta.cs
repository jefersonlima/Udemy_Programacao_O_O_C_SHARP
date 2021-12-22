using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooDestruidores
{
    public class Ferramenta
    {
        public Ferramenta( String nome)
        {
            this.Nome = nome;
        }

        ~Ferramenta()
        {
            Console.WriteLine("A sua ferramenta " + this.Nome + " Foi Destruida!");
        }
        public String Nome { get; set; }
    }
}
