using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePOOFuncionario.Entidade
{
  internal class Funcionario
  {
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public double SalarioLiquido() {
      return this.SalarioBruto - Imposto;
    }

    public void AumentarSalario(double porcentagem) {
      double aumento;
      aumento = (this.SalarioBruto * porcentagem) /100;
      this.SalarioBruto += aumento;
    }

    public override string ToString()
    {
       return this.Nome + ", $"+ this.SalarioLiquido();


    }

  }
}
