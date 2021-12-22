using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa6JogoDaAdivinhacao
{
    public class NovaPergunta:PerguntaJogo
    {
        #region Construtores
        public NovaPergunta():base()
        {
            this.Dica = "";
        }
        public NovaPergunta(String pergunta, String resposta, String dica):base(pergunta, resposta)
        {
            this.Dica = dica;
        }
        #endregion

        #region Atributos
        public String Dica { get; set; }
        #endregion
    }
}
