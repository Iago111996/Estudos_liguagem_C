namespace class08
{
  class Program
  {
    enum WeekDays
    {
      Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    static void Main(string[] args)
    {
      WeekDays ds = WeekDays.Friday;

      //e possivel pegar pelo index
      WeekDays ds1 = (WeekDays)0;

      //e possivel pegar o valor do index 
      int n = (int)WeekDays.Sunday; //operacao de typecast

      //goto e uma ancora

      System.Console.WriteLine(n);
    }
  }
}