﻿// See https://aka.ms/new-console-template for more information

namespace PasswordHW1;

class Program
{
    static void Main()
    {
        PasswordGenerator generator = new PasswordGenerator();
        Console.WriteLine(generator.GetPassword());
    }
}