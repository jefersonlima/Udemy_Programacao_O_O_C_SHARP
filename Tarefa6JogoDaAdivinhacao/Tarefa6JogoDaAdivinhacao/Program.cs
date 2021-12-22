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
            int resp = 1;

            while (resp != 0)
            {
                resp = Menu();
                if (resp == 1)
                {
                    perguntasCadastradas.ListarPerguntas();
                    Console.WriteLine();
                }
                if (resp == 2)
                {
                    perguntasCadastradas.ListarPerguntas();
                    Console.WriteLine("escolha ocódigo da pergunta que deseja responder");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    NovaPergunta np = perguntasCadastradas.Perguntas[codigo];

                    Console.WriteLine("Responda: " + np.Pergunta);
                    String resposta = Console.ReadLine();

                    if(resposta.ToUpper() == np.Resposta.ToUpper())
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
                            Console.WriteLine("Resposta errada! mesmo com a dica!\n");
                        }
                    }
                }
            }



            Console.ReadKey();
        }

        static int Menu()
        {
            Console.WriteLine("Jogo de adivinhação");
            Console.WriteLine("0 - Sair do jogo");
            Console.WriteLine("1 - Listar todas perguntas");
            Console.WriteLine("2 - Responder");
            Console.WriteLine("Escolha uma opção: ");
            int resp = Convert.ToInt32(Console.ReadLine());

            return resp;
        }
    }
}
