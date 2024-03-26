using System;
using System.Formats.Asn1;
using System.Globalization;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area =  retangulo.Area(retangulo.Largura, retangulo.Altura);
            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));

            double perimetro = retangulo.Perimetro(retangulo.Largura, retangulo.Altura);
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));

            double diagonal = retangulo.Diagonal(retangulo.Largura, retangulo.Altura);
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}