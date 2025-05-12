
using System;
using System.Security.Cryptography;

namespace ConsoleApp1
{


    class Car
    {
        public string color;
        public static int count;
    }
    public class Menu
    {
        public void RunMenu()
        {
            do
            {
                inputSeries();
                char choice = Console.ReadLine()[0];
                Console.WriteLine(
                    $"a. Input a Series. (Replace the current series)\n" +
                    $"b. Display the series in the order it was entered.\n" +
                    $"c. Display the series in the reversed order it was\r\nentered.\n" +
                    $"d. Display the series in sorted order (from low to\r\nhigh).\n" +
                    $"e. Display the Max value of the series.\n" +
                    $"f. Display the Min value of the series.\n" +
                    $"g. Display the Average of the series.\n" +
                    $"h. Display the Number of elements in the series.\n" +
                    $"i. Display the Sum of the series.\n" +
                    $"j. Exit.");

                switch
            } while (true) ;
            }


    }
        class Program
        {


            static void Main(string[] args)
            {



            }
        }



    }
