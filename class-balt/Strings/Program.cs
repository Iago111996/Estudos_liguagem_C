using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
          var id = Guid.NewGuid(); //gera um hashe

          var name = "iago";
          var num = 2443;
          var converteForString = num.ToString().Substring(0, 1); 

          var texto = "testando";

          var res = texto.CompareTo("oi");
          var res2 = texto.Contains("helllo");
          var res3 = texto.Contains("helllo", StringComparison.OrdinalIgnoreCase);

        }
    }
}