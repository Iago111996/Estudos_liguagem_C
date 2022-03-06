using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_ByteBanck
{
    public class Program
    {
        static void Main(string[] args)
        {
          var contaDaGabriela = new ContaCorrente();

          contaDaGabriela.titular = "Gabriela";
          contaDaGabriela.agencia = 863;
          contaDaGabriela.numero = 863452;
          contaDaGabriela.saldo = 100;

          Console.WriteLine(contaDaGabriela.titular);
        }
    }
}