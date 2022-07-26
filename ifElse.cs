using System;
class ifElse
{
    static void Main(string[] args)
    {

        int x = 10;

        Console.WriteLine("Bom dia");

        if (x < 5)
        {
            Console.WriteLine("Boa tarde");
        }
        else
        {
            Console.WriteLine("Boa noite");
        }

        Console.WriteLine("------");

        Console.WriteLine("Entre com um numero inteiro");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("O numero é par");
        }
        else
        {
            Console.WriteLine("O numero é impar");
        }

        Console.WriteLine("------");

        Console.WriteLine("Insira a hora atual");
        int hora = int.Parse(Console.ReadLine());

        if (hora < 12)
        {
            Console.WriteLine("Bom dia");
        }
        else if (hora >= 12 && hora < 18)
        {
            Console.WriteLine("Boa tarde");
        }
        else
        {
            Console.WriteLine("Boa noie");
        }

    }

}