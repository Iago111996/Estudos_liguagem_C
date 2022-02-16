using System;

namespace Class10
{

  class Program
  {
    static void Main(string[] args)
    {
      int[] num = new int[10];

      int ii = 0;

      do
      {
        System.Console.WriteLine("whilw{0}", ii);
        ii++;
      } while (ii < 10);

      while (ii < 10)
      {
        System.Console.WriteLine("whilw{0}", ii);
        ii++;
      }

      for (int i = 0; i < num.Length; i++)
      {
        num[i] = 0;

        System.Console.WriteLine("valor{0}: {1}", i, num[i]);
      }
    }
  }

}