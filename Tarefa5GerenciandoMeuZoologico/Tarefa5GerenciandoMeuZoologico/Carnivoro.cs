using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa5GerenciandoMeuZoologico
{
    public class Carnivoro:Animal
    {
        #region Construtores
        public Carnivoro():base()
        {
           
        }

        public Carnivoro(String especie, double peso):base()
        {
            this.Especie = especie;
            this.Peso = peso;
        }
        #endregion
    }
}
