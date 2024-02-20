using System;
using System.Text.RegularExpressions;

namespace Uppgift_6_10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ange en sträng för att undersöka hur många siffror den innehåller");
            Console.WriteLine(AntalTalIText(Console.ReadLine()));
        }

        static int AntalTalIText(string text)
        {
            Regex regex = new(@"\b\d+[\,|\.]?\d*\b");

            MatchCollection matches = regex.Matches(text);

            return matches.Count;

            //Jag använder mig av ett reguljärt uttryck för att söka genom hela strängen efter siffror, på detta sätt så kan man skriva in både "." och "," för decimaltat.
        }
    }
}