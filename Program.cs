using ConsolePOOFuncionario.Entidade;
using System.Globalization;
// See https://aka.ms/new-console-template for more information

Funcionario funcionario = new Funcionario();

Console.Write("Informe o nome do funcionario:");
funcionario.Nome = Console.ReadLine();

Console.Write("Informe o salário Bruto:");
funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Informe o imposto: ");
funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Funcionario :" + funcionario);
Console.WriteLine("Digite a porcetagem para aumentar o salário: ");

funcionario.AumentarSalario(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
Console.WriteLine("Dados Atualizados " + funcionario);

