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

          var contaDaGabrielaCosta = new ContaCorrente();

          contaDaGabrielaCosta.titular = "Gabriela";
          contaDaGabrielaCosta.agencia = 863;
          contaDaGabrielaCosta.numero = 863452;
          contaDaGabrielaCosta.saldo = 100;

          int num = 27;
          int num2 = 27;

          //contaDaGabriela != contaDaGabrielaCosta => tipos de referencia;

          //num == num2 => tipos de valores;


          Console.WriteLine(contaDaGabriela.titular);
        }
    }
}