using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa5GerenciandoMeuZoologico
{
    class Herbivoro:Animal
    {
        #region Construtores
        public Herbivoro() : base()
        {

        }

        public Herbivoro(String especie, double peso) : base()
        {
            this.Especie = especie;
            this.Peso = peso;
        }
        #endregion
    }

}
