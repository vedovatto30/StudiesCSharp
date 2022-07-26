using System;

class operadoresComparativos
{
    public static void Main(string[] args)
    {

        int a = 10;
        bool c1 = a < 10;
        bool c2 = a < 20;

        Console.WriteLine(c1);
        Console.WriteLine(c2);

        Console.WriteLine("--------");
      bool c3 = 2 > 3 || 4 != 5;
      bool c4 = !(2 > 3) && 4 != 5;

      Console.WriteLine(c3);
      Console.WriteLine(c4);

      Console.WriteLine("------");

      bool c5 = 10 < 5;
      bool c6 = c1 || c2 && c3;

      Console.WriteLine(c5);
      Console.WriteLine(c6);
    }
}