using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPolimorfismo
{
    public class Quadrado:Formas
    {
        public Quadrado():base()
        {
            base.FormaGeometrica = "Quadrado";
        }

        public Quadrado( Double Base, Double Altura) : base("Quadrado", Base, Altura)
        {

        }
        private String formaGeometrica;

        public override String FormaGeometrica
        {
            get { return base.FormaGeometrica; }
            
        }


        public override Double CalcularArea()
        {
            return this.Base * this.Altura;
        }
    }
}
