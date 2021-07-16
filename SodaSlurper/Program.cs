using System;

namespace SodaSlurper
{
    class Program
    {
        static void Main(string[] args)
        {
            int e; //e < 1000 equals the number of empty soda bottles in Tim’s possession at the start of the day
            int f; //f < 1000 the number of empty soda bottles found during the day
            int c; //2 ≤ c < 2000 the number of empty bottles required to buy a new soda

            //How many sodas did Tim drink on his extra thirsty day?
            string input = Console.ReadLine(); //e f c

            string[] inputArray =  input.Split(" ");

            e = int.Parse(inputArray[0]);
            f = int.Parse(inputArray[1]);
            c = int.Parse(inputArray[2]);
            double emptyBootles = e + f;

            double totalNumberOfBootles = 0;

            while (emptyBootles >= c)
            {
                double bootlesToBuy = Math.Floor(emptyBootles / c);
                double leftovers = emptyBootles % c;
                emptyBootles = leftovers + bootlesToBuy;

                totalNumberOfBootles += bootlesToBuy;
            }

            

            Console.WriteLine(totalNumberOfBootles);
        }
    }
}
