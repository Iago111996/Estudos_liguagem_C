using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos
{
  public class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("O que deseja fazer ?");

      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtracao");
      Console.WriteLine("3 - Divisao");
      Console.WriteLine("4 - Multiplicacao");

      Console.WriteLine("-------------------------");

      Console.WriteLine("Escolha sua opcao!");

      int res = int.Parse(Console.ReadLine());

      switch (res)
      {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;

        default: Menu(); break;
      }
    }
    static void Soma()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor: ");
      double v1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      double v2 = double.Parse(Console.ReadLine());

      Console.WriteLine("");

      double resultado = v1 + v2;

      Console.WriteLine($"O resultado da soma é: {resultado}");
      Console.ReadKey();

      Menu();
    }

    static void Subtracao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor: ");
      double v1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      double v2 = double.Parse(Console.ReadLine());

      Console.WriteLine("");

      double resultado = v1 - v2;

      Console.WriteLine($"O resultado da subtracao é: {resultado}");
      Console.ReadKey();

      Menu();
    }


    static void Divisao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor: ");
      double v1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      double v2 = double.Parse(Console.ReadLine());

      Console.WriteLine("");

      double resultado = v1 / v2;

      Console.WriteLine($"O resultado da divisao é: {resultado}");
      Console.ReadKey();

      Menu();
    }

    static void Multiplicacao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor: ");
      double v1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      double v2 = double.Parse(Console.ReadLine());

      Console.WriteLine("");

      double resultado = v1 * v2;

      Console.WriteLine($"O resultado da multiplicacao é: {resultado}");
      Console.ReadKey();

      Menu();
    }

  }
}