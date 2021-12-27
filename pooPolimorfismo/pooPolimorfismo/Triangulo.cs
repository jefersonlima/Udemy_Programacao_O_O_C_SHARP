using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPolimorfismo
{
    public class Triangulo:Formas
    {

        public Triangulo():base()
        {
            base.FormaGeometrica = "Triangulo";
        }

        public Triangulo( Double Base, Double Altura) : base("Triangulo", Base, Altura)
        {

        }
        public override string FormaGeometrica { get => base.FormaGeometrica; }

        public override Double CalcularArea()
        {
            return this.Base * this.Altura / 2;
        }
    }
}
