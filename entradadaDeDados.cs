using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Escreva uma frase");
    string frase = Console.ReadLine(); /// colocarei batata tomate abacaxi

    Console.WriteLine("o que vc escreveu :" + frase);

    string[] vet = Console.ReadLine().Split(' ');
    string p1 = vet[0];
    string p2 = vet[1];
    string p3 = vet[2];

    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(p3);
  }
}