using System;

class entradaInt
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Insira um int");
        int n1 = int.Parse(Console.ReadLine());
        char ch = char.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Você digitou: ");
        Console.WriteLine(n1);
        Console.WriteLine(ch);
        Console.WriteLine(n2);

        //ou podemos recortar uma linha

        Console.WriteLine(" Insira as informações de nome, sexo e idade");
        string[] vet = Console.ReadLine().Split(" ");

        string nome = vet[0];
        char sexo = char.Parse(vet[1]);
        double idade = double.Parse(vet[2]);
        
        Console.WriteLine("Voce digitou: " + nome + sexo + idade);
    }

}