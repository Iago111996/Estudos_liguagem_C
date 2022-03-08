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
      var gereciador = new GerenciadorBonificacao();

      var carlos = new Funcionario();

      carlos.Nome = "Carlos";
      carlos.CPF = "000-039-987-23";
      carlos.Salario = 2000;

      gereciador.Regitrar(carlos);

      var roberta = new Diretor();

      roberta.Nome = "roberta";
      roberta.CPF = "000-039-987-23";
      roberta.Salario = 5000;

      gereciador.Regitrar(roberta);


      Console.WriteLine();
    }
  }
}