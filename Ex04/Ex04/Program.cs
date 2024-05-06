using System;
using System.Globalization;
namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            
            Console.Write("Sálario Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioliquido = funcionario.SalarioLiquido();

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + funcionario.Nome + ", " + "$ " + salarioliquido.ToString("F2", CultureInfo.InvariantCulture
                ));

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            funcionario.AumentarSalario(percentual);
            Console.WriteLine(funcionario);



        }
    }
}