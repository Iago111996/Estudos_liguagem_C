using System;

namespace class02
{
  class Program
  {
    static int num = 10; //variable global
    static void Main(string[] args)
    {
      int num2 = 1;

      Console.WriteLine("Hello world!" + num + num2);
    }

    static void teste(string[] args)
    {
      int num3 = 5;

      Console.WriteLine("Hello world!" + num + num3);
    }


  }
}