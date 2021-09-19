using System;

namespace AtvParadigmasProgramacao
{
    public class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo() { }

        public Retangulo(double aLargura, double aAltura)
        {
            this.Largura = aLargura;
            this.Altura = aAltura;
        }

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Altura * Altura) + (Largura * Largura));
        }
    }
}
