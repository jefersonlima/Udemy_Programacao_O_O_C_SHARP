using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntaEResposta
{
    public class PerguntaPlus : Pergunta
    {
        #region Construtores
        public PerguntaPlus():base()
        {
            //:base() no construtor chama o contrutor da classe PAI
            this.Dica = "";
            //this.test1 = ""; //atributo public
            //this.test3 = ""; //atributo protected
        }

        public PerguntaPlus(String texto, String resposta, String dica) : base()
        {
            //:base() no construtor chama o contrutor da classe PAI
            this.Dica = dica;
        }
        #endregion

        #region Atributos
        public String Dica { get; set; }
        #endregion
    }
}
