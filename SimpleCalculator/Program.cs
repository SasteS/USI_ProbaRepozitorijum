﻿using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("broj operacija broj");
        string[] s = Console.ReadLine().Split(" ");

        int a = Convert.ToInt32(s[0]), b = Convert.ToInt32(s[2]), r = 0;
        string operacija = s[1];

        switch (operacija)
        {
            case "+":
                r = a + b;       
                break;
            case "-":
                r = a - b;
                break;
            case "*":
                r = a * b;
                break;
            case "/":
                r = a / b;
                break;
            default:
                r = 0;
                break;
        }

        Console.WriteLine("rezultat = " + r.ToString());
    }

}