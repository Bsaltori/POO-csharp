using System;
using System.Globalization;

namespace Ex03
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area(double Largura, double Altura)
        {
            return Largura * Altura;
        }

        public double Perimetro(double Largura, double Altura)
        {
            
            return 2.0 * (Largura + Altura);
        }

        public double Diagonal(double Largura, double Altura)
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }

    }


}
