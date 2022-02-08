using System;

namespace class09
{
  class Program
  {
    static void Main(string[] args)
    {
      // array - vetor
      int[] vetor = new int[5];

      int[] vetor1 = new int[3]{55,77,99};

      int[] vetor2 = {55,77,99};

      // add element
      vetor[0] = 111;
      vetor[1] = 222;
      vetor[2] = 333;
      vetor[3] = 444;
      vetor[4] = 555;

      System.Console.WriteLine(vetor2[0]);
    }
  }
}