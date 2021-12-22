using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa6JogoDaAdivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Descrição da Tarefa
            //Atividade - Jogo da Adivinhação

            //Crie um jogo no qual é apresentado para o usuário uma pergunta e uma dica.
            //O usuário terá três tentativas para acertar a pergunta.Caso o usuário erre a pergunta, você deverá informar uma dica para o usuário.
            //Caso erre a pergunta o usuário deverá receber uma mensagem informando que perdeu o jogo,
            //caso acerte a pergunta o usuário receberá uma mensagem parabenizando o mesmo.
            //O programa deverá escolher(sortear) dentre 10 perguntas a pergunta que será exibida para o jogador.

            //IMPORTANTE
            //Para revisar os conceitos passados em sala de aula o aluno deverá implementar duas classes(PerguntaJogo e NovaPergunta)
            //para representar as perguntas do jogo.
            //O texto descreve o que deverá estar presente nas classes.

            //CLASSE PERGUNTAJOGO
            //Propriedades - Pergunta e Resposta(Ambas do tipo String)

            //CLASSE NOVAPERGUNTA
            //Deverá herdar as características da classe PERGUNTA e mais a característica Dica(A característica dica deverá ser do tipo String).

            //Perguntas dessa tarefa
            //Crie um programa em modo console.

            //Adicione os códigos gerados na resposta.
            #endregion

            TodasPerguntasDoJogo perguntasCadastradas = new TodasPerguntasDoJogo();
            MenuAdivinhacao menu = new MenuAdivinhacao();

            int resp = 1;

            while (resp != 0)
            {
                resp = menu.MenuJogo();
                if (resp == 1)
                {
                    perguntasCadastradas.ListarPerguntas();
                    Console.WriteLine();
                }
                if (resp == 2)
                {
                    perguntasCadastradas.JogarEscolha();
                }
                if (resp == 3)
                {
                    perguntasCadastradas.JogarAleatorio();
                }
            }
            Console.ReadKey();
        }
    }
}
