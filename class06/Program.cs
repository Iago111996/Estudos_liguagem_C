namespace class06
{
  class Program
  {
    static void Main(string[] args)
    {
      int n1, n2, soma;
      string name;

      Console.Write("Digite n1: ");
      n1 = int.Parse(Console.ReadLine());

      Console.Write("Digite n2: ");
      n2 = Convert.ToInt32(Console.ReadLine());
      soma = n1 + n2;

      Console.Write("A soma de n1: {0} mais n2={1} = {2}", n1, n2, soma);
    }
  }
}