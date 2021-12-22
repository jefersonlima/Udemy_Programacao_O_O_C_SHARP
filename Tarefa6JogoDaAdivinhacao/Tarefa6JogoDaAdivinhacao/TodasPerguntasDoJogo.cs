using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa6JogoDaAdivinhacao
{
    public class TodasPerguntasDoJogo
    {
        #region Contrutores
        public TodasPerguntasDoJogo()
        {
            this.CarregarPergutas();
        }
        #endregion

        #region Atributos
        private List<NovaPergunta> perguntas;
        public List<NovaPergunta> Perguntas 
        { 
            get { return perguntas;  }
        }
        #endregion

        #region Metodos
        private void CarregarPergutas()
        {
            //Instanciar a lista
            this.perguntas = new List<NovaPergunta>();

            //Crinado o objeto
            NovaPergunta pj;

            //instanciando os Objetos e add na lista
            pj = new NovaPergunta("Todo Computador tem!", "Teclado", "É usado para digitae");
            this.perguntas.Add(pj);

            pj = new NovaPergunta("Pergunta2", "Resposta2", "Dica2");
            this.perguntas.Add(pj);

            pj = new NovaPergunta("Pergunta3", "Resposta3", "Dica3");
            this.perguntas.Add(pj);

            this.perguntas.Add(new NovaPergunta("Pergunta4", "Resposta4", "Dica4"));
        }

        public void ListarPerguntas()
        {
            for (int i = 0; i < this.Perguntas.Count; i++)
            {
                Console.WriteLine("Pergunta - (" + i + ") " + this.Perguntas[i].Pergunta);
            }
        }

        public void ListarPerguntasComDicas()
        {
            for (int i = 0; i < this.Perguntas.Count; i++)
            {
                Console.WriteLine("Pergunta: " + this.Perguntas[i].Pergunta);
                Console.WriteLine("Dica: " + this.Perguntas[i].Dica);
            }
        }

        #endregion
    }
}
