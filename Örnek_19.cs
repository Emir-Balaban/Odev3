﻿using System;

class faktoriyel
{
    static int Faktoriyel(int a)
    {
        if (a == 0)
            return 1;
        return a * Faktoriyel(a - 1);
    }
    static void Main()
    {
        Console.WriteLine("Faktöriyelini alacağınız sayıyı giriniz:");
        int fak_değeri = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Girmiş olduğu sayının faktöriyeli: " + Faktoriyel(fak_değeri));

    }
}