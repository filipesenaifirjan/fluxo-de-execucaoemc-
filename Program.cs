﻿ class Program
{
    static void Main(string[] args)
    {
        
        int valor1;
        int valor2;
        int total;

        Console.WriteLine("digite o primeiro valor");
        valor1= int.Parse(Console.ReadLine());
        Console.WriteLine("O primeiro valor é: " + valor1);

        Console.WriteLine("digite o segundo valor");
        valor2= int.Parse(Console.ReadLine());
        Console.WriteLine("O segundo valor é: " + valor2);

        total = valor1 + valor2;
        Console.WriteLine("A soma dos dois valores é: " + total);
    }
}