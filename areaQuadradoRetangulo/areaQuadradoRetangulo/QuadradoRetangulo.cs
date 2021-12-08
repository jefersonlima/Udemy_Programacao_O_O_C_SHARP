using System;

namespace areaQuadradoRetangulo
{
    class QuadradoRetangulo
    {
        #region Contrutor
        public QuadradoRetangulo()
        {
            this.baseQuadrado = 0;
            this.alturaQuadrado = 0;
        }
        #endregion

        #region Propriedades

        #region Base do Quadrado Retangulo
        private Double baseQuadrado;

        public Double BaseQuadrado
        {
            get { return baseQuadrado; }
            set {
                if (value >= 0) this.baseQuadrado = value;
                else this.baseQuadrado = 0; 
            }
        }
        #endregion

        #region Altura do Quadrado Retangulo
        private Double alturaQuadrado;

        public Double AlturaQuadrado
        {
            get { return alturaQuadrado; }
            set {
                if (value >= 0) this.alturaQuadrado = value;
                else this.alturaQuadrado = 0; 
            }
        }
        #endregion

        #region Area do Quadrado Retangulo
        public Double AreaQuadrado
        {
            get { return baseQuadrado * alturaQuadrado; }
        }
        #endregion

        #endregion

        #region Metodos
        #region Exibir Area do Quadrado Retangulo
        public void ExibirAreaQuadradoRetangulo()
        {
            Console.WriteLine("Area do Quadrado Retangulo: " + this.AreaQuadrado);
            Console.WriteLine();
        }
        #endregion

        #region Exibir todos dados do Quadrado Retangulo
        public void ExibirTodosDadosQuadradoRetangulo()
        {
            Console.WriteLine("Base do Quadrado Retangulo: " + this.baseQuadrado);
            Console.WriteLine("Altura do Quadrado Retangulo: " + this.alturaQuadrado);
            Console.WriteLine("Area do Quadrado Retangulo: " + this.AreaQuadrado);
            Console.WriteLine();
        }
        #endregion

        #endregion
    }
}
