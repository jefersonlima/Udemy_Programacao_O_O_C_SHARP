using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeJogos
{
    public class ListaDeJogos
    {
        private List<Jogo> jogos;
        public List<Jogo> Jogos 
        { 
            get
            {
                return jogos;
            }
                
        }
        /*
         //* Cadastrar um jogo;
         * Excluir um jogo;
         * Alterar um jogo;
         * Localizar jogod por nome;
         * Localizar jogos por gênero;
         * Listar todos os jogos;
         * Listar todos os jogos por gêneto;
         * Listar todos os jogos por console;
         */

        public ListaDeJogos()
        {
            jogos = new List<Jogo>();
        }

        public Boolean Inserir(Jogo jogo)
        {
            Boolean resultado = true;
            try
            {
                Jogo j = jogos.Find(x => x.Id == jogo.Id);
                if (j == null)
                {
                    jogos.Add(jogo);
                }
                else
                {
                    resultado = false;
                }
            }
            catch (Exception erro)
            {

                resultado = false;
            }
            return resultado;
        }
    }
}
