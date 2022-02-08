using System;

namespace class02
{
  class Program
  {
    static void Main(string[] args)
    {
      byte n1 = 10; // 8byts => 0 a 255;
      int num = 0; // 32byts
      int numn = -2; // can be negative
      float values = 0.3f;
      double values1 = 3.50;
      char character = 'O';
      bool res = 10 < 5;

      string line = "ola"; // 1 type reference group of char

      var aux = 10; //give a reference
      const string canal = "blala";

      //example
      int num1, num2, num3;

      num1 = 0;
      num2 = 10;
      num3 = -2;

      Console.WriteLine("Hello world!" + num + num3);
    }
  }
}