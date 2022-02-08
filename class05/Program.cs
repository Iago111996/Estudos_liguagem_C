using System;

namespace class02
{
  class Program
  {
    static void Main(string[] args)
    {
      //opreradores

      //atricuicao
      int i = 0 + 5;

      //incremento i = i + 1; i++; (+, -, /, *)
      i += 1;

      //comparacao < > >= <= == !=
      bool res = 10 == 5;

      //logicos & => AND e | => OR
      bool res1 = (5 > 4) | (3 > 4);
      bool res2 = (5 > 4) & (3 > 4);

      int n1 = 10, n2 = 20, n3 = 30;

      const string canal = "blala";

      Console.WriteLine("n1={0}, n2={1}, n3={2}, canal={3}", n1, n2, n3, canal);
    }

  }
}