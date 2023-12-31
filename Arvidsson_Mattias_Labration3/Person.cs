﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvidsson_Mattias_Labration3
{
    // En klass som representerar en person med olika attribut som kön, hår, födelsedatum och ögonfärg.
    public class Person
    {
        // Attribut för personens kön med en privat set-metod för att säkerställa inkapsling.
        public Gender Gender { get; private set; }
        // Attribut för personens hårdetaljer med en privat set-metod för att säkerställa inkapsling.
        public Hair HairDetails { get; private set; }
        // Attribut för personens födelsedatum med en privat set-metod för att säkerställa inkapsling.
        public DateTime Birthdate { get; private set; }
        // Attribut för personens ögonfärg med en privat set-metod för att säkerställa inkapsling.
        public string? EyeColor { get; private set; }

        // Konstruktor som används för att skapa en instans av Person med specificerade attribut.
        public Person(Gender gender, Hair hair, DateTime birthday, string eyeColor)
        {
            Gender = gender;
            HairDetails = hair;
            Birthdate = birthday;
            EyeColor = eyeColor;
        }
        // Överskriden ToString-metod för att skapa en strängrepresentation av objektet.
        public override string ToString()
        {
            return  $"Gender: {Gender}\n" +
                    $"Hair: Length - {HairDetails.HairLength}cm, Color - {HairDetails.HairColor}\n" +
                    $"Birthday: {Birthdate.ToShortDateString()}\n" +
                    $"Eyecolor: {EyeColor}";
        }
    }
}
