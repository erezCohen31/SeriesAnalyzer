

namespace SeriesAnalyser
{
    class Program
    {
        static List<int> series = new List<int>();
        static int count = 0;
        static bool InputSeries(string[] args)
        {

            if (verifySeriesArgs(args) && count == 0)
            {
                count++;
                return true;
            }
            else
            {
                if (count == 0) { Console.WriteLine("Invalid input. Please enter a series of numbers."); }
                string seriesInString = Console.ReadLine();
                if (verifySeries(seriesInString))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a series of numbers.");
                    return false;
                }
            }


        }
        static bool verifySeries(string input)
        {
            string currentNum = "";
            List<int> seriesCurrent = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    seriesCurrent.Add(int.Parse(currentNum));
                    currentNum = "";
                    continue;
                }
                else if (i == (input.Length - 1))
                {
                    currentNum += input[i];
                    seriesCurrent.Add(int.Parse(currentNum));
                    currentNum = "";
                    continue;

                }
                else if (input[i] >= 48 && input[i] <= 57)
                {
                    currentNum += input[i];
                    continue;
                }
                else
                {
                    return false;
                }
            }
            series = seriesCurrent;
            return series.Count >= 3 ? true : false;

        }
        static bool verifySeriesArgs(string[] args)
        {
            string currentNum = "";
            List<int> seriesCurrent = new List<int>();
            for (int i = 0; i < args.Length; i++)
            {
                if (int.TryParse(args[i], out int nombre))

                {
                    currentNum += args[i];
                    seriesCurrent.Add(int.Parse(args[i]));

                }
                else
                {
                    return false;
                }
            }
            series = seriesCurrent;
            return series.Count >= 3 ? true : false;
        }
        static void Display(List<int> series)
        {
            foreach (int num in series)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
        }
        static void Display(int num)
        {
            Console.WriteLine(num);
        }
        static void Display(double num)
        {
            Console.WriteLine(num);
        }
        static List<int> ToReverse(List<int> series)
        {
            List<int> reverse = new List<int>();
            for (int i = series.Count - 1; i >= 0; i--)
            {
                reverse.Add(series[i]);
            }
            return reverse;
        }
        static List<int> ToSorted(List<int> series)
        {
            List<int> sorted = series;
            sorted.Sort();
            return sorted;
        }
        static int FindMax(List<int> series)
        {
            List<int> sorted = ToSorted(series);
            return sorted[sorted.Count - 1];
        }
        static int FindMin(List<int> series)
        {
            List<int> sorted = ToSorted(series);
            return sorted[0];
        }
        static double FindAverage(List<int> series)
        {
            double sum = 0;
            foreach (double num in series)
            {
                sum += num;
            }
            return sum / series.Count;
        }
        static int FindLength(List<int> series)
        {
            return series.Count;
        }
        static int FindSum(List<int> series)
        {
            int sum = 0;
            foreach (int num in series)
            {
                sum += num;
            }
            return sum;
        }
        static public void RunMenu(string[] args)
        {
            bool isBegan = false;
            bool isContinue = true;

            while (!isBegan)
            {
                Console.WriteLine("Input a Series.");
                isBegan = InputSeries(args) ? true : false;
            }


            while (isContinue)
            {
                Console.WriteLine(
                    $"a. Input a Series. (Replace the current series)\n" +
                    $"b. Display the series in the order it was entered.\n" +
                    $"c. Display the series in the reversed order it was entered.\n" +
                    $"d. Display the series in sorted order (from low to high).\n" +
                    $"e. Display the Max value of the series.\n" +
                    $"f. Display the Min value of the series.\n" +
                    $"g. Display the Average of the series.\n" +
                    $"h. Display the Number of elements in the series.\n" +
                    $"i. Display the Sum of the series.\n" +
                    $"j. Exit.");
                char choice = Console.ReadLine()[0];

                switch (choice)
                {
                    case 'a':
                        Console.WriteLine("Input a series of numbers: ");
                        InputSeries(args);
                        break;
                    case 'b':
                        Console.WriteLine("Your series in order: ");
                        Display(series);
                        break;
                    case 'c':
                        Console.WriteLine("Your series in reverse: ");
                        Display(ToReverse(series));
                        break;
                    case 'd':
                        Console.WriteLine("Your series sorted: ");
                        Display(ToSorted(series));
                        break;
                    case 'e':
                        Console.WriteLine("The max is series: ");
                        Display(FindMax(series));
                        break;
                    case 'f':
                        Console.WriteLine("The min is series: ");
                        Display(FindMin(series));
                        break;
                    case 'g':
                        Console.WriteLine("The average is: ");
                        Display(FindAverage(series));
                        break;
                    case 'h':
                        Console.WriteLine("The legth of the series is: ");
                        Display(FindLength(series));
                        break;
                    case 'i':
                        Console.WriteLine("The sum of the series is: ");
                        Display(FindSum(series));
                        break;
                    case 'j':
                        isContinue = false;
                        break;
                    default:
                        break;


                }
            }
        }
        static void Main(string[] args)
        {

            RunMenu(args);

        }
    }



}
