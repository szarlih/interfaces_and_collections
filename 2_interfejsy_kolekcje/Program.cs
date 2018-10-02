/******************************************************************/
/// <copyright file="Program.cs" company="Sharpro">
/// Copyright (c) 2018 All Rights Reserved
/// </copyright>
/// <author>Jarosław Mielewski</author>
/// <date>16:03</date>
/******************************************************************/

namespace _2_interfejsy_kolekcje
{
    using System;
    using Extensions;

    class Program
    {
        static void Main(string[] args)
        {
            MySpecialCollection collection = new MySpecialCollection();
            collection = new MySpecialCollection();
            Console.WriteLine(collection);
            Console.WriteLine(collection.LongerThanFiveElements());
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
