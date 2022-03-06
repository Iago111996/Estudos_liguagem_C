using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_ByteBanck
{
    public class Program
    {
        static void Main(string[] args)
        {
          // var gabriela = new Cliente();

          // gabriela.nome = "Gabriela";
          // gabriela.profissao = "Desenvolvedora";
          // gabriela.cpf = "047-503-092-03";

          var conta = new ContaCorrente();

          conta.titular = new Cliente();
          
          conta.titular.nome = "Gabriela";
          conta.titular.profissao = "Desenvolvedora";
          conta.titular.cpf = "047-503-092-03";

          conta.saldo = 500;
          conta.agencia = 563;
          conta.numero = 5634527;
         
          Console.WriteLine();
        }
    }
}