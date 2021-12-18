using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa5GerenciandoMeuZoologico
{
    public class Animal
    {
        #region Construtores
        public Animal()
        {
            this.Especie = "";
            this.Peso = 0;
        }

        public Animal(String especie, double peso)
        {
            this.Especie = especie;
            this.Peso = peso;
        }
        #endregion

        #region Atributos
        public String Especie { get; set; }
        public double Peso { get; set; }
        //public String Alimentacao  { get; set; }
        #endregion

        #region Metodos
        public override String ToString()
        {
            return "Especie: " + this.Especie + "\nPeso: " + this.Peso + "kg.";
        }
        #endregion
    }
}
