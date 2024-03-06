using System;
class HelloWorld
{
    static void Main()
    {
        string nome = "Fellipe", nome2 = "Davi";

        Console.Write("Digite a idade do Fellipe: ");
        int idadefellipe = int.Parse(Console.ReadLine());

        Console.Write("Digite a idade do Davi: ");
        int idadedavi = int.Parse(Console.ReadLine());

        int idade = idadedavi + idadefellipe;

        Console.WriteLine($"{nome} e {nome2}. Juntos os dois tem {idade} anos.");
    }
}
