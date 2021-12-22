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
            pj = new NovaPergunta("Todo Computador tem!", "Teclado", "É usado para digitar");
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

        public void JogarEscolha()
        {
            ListarPerguntas();
            Console.WriteLine("escolha ocódigo da pergunta que deseja responder");
            int codigo;
            try
            {
                codigo = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Você informou um valor inválido! será escolhido uma pergunta aleatória!!");
                Random r = new Random();
                codigo = r.Next(0, Perguntas.Count);   
            }
            
            NovaPergunta np = Perguntas[codigo];

            Console.WriteLine("Responda: " + np.Pergunta);
            String resposta = Console.ReadLine();

            if (resposta.ToUpper() == np.Resposta.ToUpper())
            {
                Console.WriteLine("Parabéns!! você acertou.\n");
            }
            else
            {
                Console.WriteLine("Resposta errada!");
                Console.WriteLine("Dica: " + np.Dica);
                Console.WriteLine("Responda: " + np.Pergunta + "\n");
                resposta = Console.ReadLine();

                if (resposta.ToUpper() == np.Resposta.ToUpper())
                {
                    Console.WriteLine("Parabéns!! você acertou usando a dica.\n");
                }
                else
                {
                    Console.WriteLine("Resposta errada! mesmo com a dica!");
                    Console.WriteLine("A respota corrreta era: " + np.Resposta + "\n");
                }
            }
        }

        public void JogarAleatorio()
        {
            Random r = new Random();
            int pos = r.Next(0, Perguntas.Count);
            NovaPergunta np = Perguntas[pos];
            int tentativas = 0;
            Boolean flag = false;
            String resposta = "";

            while (tentativas < 3 && flag == false)
            {
                Console.WriteLine("Responda: " + np.Pergunta);
                resposta = Console.ReadLine();

                if (resposta.ToUpper() == np.Resposta.ToUpper())
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Resposta errada!");
                    Console.WriteLine("Dica: " + np.Dica);
                }
                tentativas++;
            }
            if (flag == true)
            {
                Console.WriteLine("Parabéns!! você acertou.\n");
            }
            else
            {
                Console.WriteLine("Resposta errada! mesmo com a dica!");
                Console.WriteLine("A respota corrreta era: " + np.Resposta + "\n");
            }
        }

        #endregion
    }
}
