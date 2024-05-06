using System;
using System.Globalization;

namespace Ex04
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double percentual)
        {
            double aumento = SalarioBruto * percentual / 100;
            SalarioBruto += aumento - Imposto;
        }

        public override string ToString()
        {
            return "Dados atualizados: " 
                + Nome
                + ", $ "
                + SalarioBruto.ToString("F2", CultureInfo.InvariantCulture);        
        }

    }
}
