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

      //matriz
      int[,] matriz = new int[2,3];

      //uma matriz
      /*
        line1 => 10 20 30 
        line2 => 10 20 30 
      */

      matriz[0,0] = 10;
      matriz[0,1] = 10;
      matriz[0,2] = 10;

      matriz[1,0] = 10;
      matriz[1,1] = 20;
      matriz[1,2] = 30;

      matriz[2,0] = 10;
      matriz[2,1] = 20;
      matriz[2,2] = 30;

      Console.WriteLine(vetor2[1]);
      Console.WriteLine(matriz[1,2]);
    }
  }
}