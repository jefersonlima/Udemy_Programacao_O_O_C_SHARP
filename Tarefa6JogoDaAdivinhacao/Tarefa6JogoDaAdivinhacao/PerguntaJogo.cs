using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa6JogoDaAdivinhacao
{
    public class PerguntaJogo
    {
        #region Construtores
        public PerguntaJogo()
        {
            this.Pergunta = "";
            this.Resposta = "";
        }
        public PerguntaJogo(String pergunta, String resposta)
        {
            this.Pergunta = pergunta;
            this.Resposta = resposta;
        }
        #endregion

        #region Atributos
        public String Pergunta { get; set; }
        public String Resposta { get; set; }
        #endregion

        #region Metodos

        #endregion
    }
}
