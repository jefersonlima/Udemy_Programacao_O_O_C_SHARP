using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    public class Pista
    {
        public Pista(int tamanho, Corredor atleta)
        {
            this.Tamanho = tamanho;
            this.Atleta = atleta;
            this.posAtleta = 0;
        }

        public int Tamanho { get; set; }

        private int posAtleta;

        public int PosAtleta
        {
            get { return this.posAtleta; }
            //set { posAtleta = value; }
        }

        public Corredor Atleta { get; set; }

        public  Boolean AtualizarCorrida()
        {
            
            Boolean ganhou = false;
            if (this.posAtleta < this.Tamanho)
            {
                this.posAtleta += this.Atleta.Correr();
                
            }
            if (this.posAtleta >= this.Tamanho)
            {
                ganhou = true;
                this.posAtleta = this.Tamanho;
            }
            
            return ganhou;
        }

        public void ExibirPista()
        {
            //Monta a imagem do corredor na pista da posição atual
            String pista = "";
            String corredorPista = "";

            for (int i = 0; i < this.Tamanho; i++)
            {
                pista += "_";
                if (i == this.posAtleta)
                {
                    corredorPista += this.Atleta.Nome;
                }
                else
                {
                    corredorPista += " ";

                }               
            }
            //exibe a pista eo corredor
            Console.WriteLine(corredorPista);
            Console.WriteLine(pista);
        }
    }
}
