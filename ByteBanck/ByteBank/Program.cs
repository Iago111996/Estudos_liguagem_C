using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
  public class Program
  {
    static void Main(string[] args)
    {
      var carlos = new Funcionario();

      carlos.Nome = "Carlos";
      carlos.CPF = "000-039-987-23";
      carlos.Salario = 2000;

      Console.WriteLine();
      
    }
  }
}