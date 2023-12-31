﻿using System.Xml.Linq;

namespace Arvidsson_Mattias_Labration3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Hårdkodade värden för en person
            Person person1 = new Person(
                Gender.Woman,
                new Hair { HairLength = 45, HairColor = "Blonde" },
                new DateTime(1989, 7, 21),
                "Green"
            );

            // Skriv ut personens information med Console.WriteLine
            Console.WriteLine("Information about the person:");
            Console.WriteLine(person1.ToString());

        }
    }
}
