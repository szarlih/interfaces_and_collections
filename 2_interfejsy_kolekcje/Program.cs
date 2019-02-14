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
    using System.Collections.Generic;
    using Extensions;

    class Program
    {
        static void Main(string[] args)
        {
            MySpecialCollection collection = new MySpecialCollection();
            collection = new MySpecialCollection();

            List<IElement> list = new List<IElement>();
            MeaningfulNameElement element = new MeaningfulNameElement(30, "kot");
            list.Add(element);
            element = new MeaningfulNameElement(20);
            list.Add(element);
            list.Add(new CollectionElement("test", 1));
            Console.WriteLine("Cel zadania: " + list[0].Name +","+list[1].Name);


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Cel zadania iteracja: " + list[i].Name);
            }

            foreach(IElement e in list)
            {
                Console.WriteLine("Cel zadania iteracja: " + e.Name);
            }

            Console.WriteLine(collection);
            Console.WriteLine(collection.LongerThanFiveElements());
            Console.ReadLine();
        }
    }
}
