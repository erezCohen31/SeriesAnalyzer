

namespace SeriesAnalyser
{
    class Program
    {
        static List<int> series = new List<int>();
        //get the args
        static bool InputSeries(string[] args)
        {
            (bool, List<int>) verif = verifySeriesArgs(args);

            if (verif.Item1)
            {
                series = verif.Item2;
                return true;
            }
            Console.WriteLine("Invalid input. Please enter a series of numbers.");
            return false;
        }
        //get input from user and enter in the list
        static bool InputSeries()
        {
            string seriesInString = Console.ReadLine();
            (bool, List<int>) verif = verifySeries(seriesInString);
            if (verif.Item1)
            {
                series = verif.Item2;
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a series of numbers.");
                return InputSeries();
            }
        }
        //verify if the input is a series of numbers and push it to the list
        static (bool, List<int>) verifySeries(string input)
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
                else if (i == (input.Length - 1) && input[i] >= 48 && input[i] <= 57)
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
                    return (false, seriesCurrent);
                }
            }
            return seriesCurrent.Count >= 3 ? (true, seriesCurrent) : (false, seriesCurrent);


        }
        //verify if the args is a series of numbers
        static (bool, List<int>) verifySeriesArgs(string[] args)
        {
            string currentNum = "";
            List<int> seriesCurrent = new List<int>();
            for (int i = 0; i < args.Length; i++)
            {
                if (int.TryParse(args[i], out int number))
                {
                    seriesCurrent.Add(number);
                }
                else
                {
                    return (false, seriesCurrent);
                }
            }
            return seriesCurrent.Count >= 3 ? (true, seriesCurrent) : (false, seriesCurrent);


        }
        //print list
        static void Display(List<int> series)
        {
            foreach (int num in series)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
        }
        //print int
        static void Display(int num)
        {
            Console.WriteLine(num);
        }
        //print double
        static void Display(double num)
        {
            Console.WriteLine(num);
        }
        //reverse list
        static List<int> ToReverse(List<int> series)
        {
            List<int> reverse = new List<int>();
            for (int i = series.Count - 1; i >= 0; i--)
            {
                reverse.Add(series[i]);
            }
            return reverse;
        }
        //sort list
        static List<int> ToSorted(List<int> series)
        {
            List<int> sorted = new List<int>(series);
            sorted.Sort();
            return sorted;
        }
        //find the max in the list
        static int FindMax(List<int> series)
        {
            List<int> sorted = ToSorted(series);
            return sorted[sorted.Count - 1];
        }
        //find the min in the list
        static int FindMin(List<int> series)
        {
            List<int> sorted = ToSorted(series);
            return sorted[0];
        }
        //calculate the average of the list
        static double FindAverage(List<int> series)
        {
            double sum = 0;
            foreach (double num in series)
            {
                sum += num;
            }
            return sum / series.Count;
        }
        //return the length of the list
        static int FindLength(List<int> series)
        {
            return series.Count;
        }
        //calculate the sum of the list
        static int FindSum(List<int> series)
        {
            int sum = 0;
            foreach (int num in series)
            {
                sum += num;
            }
            return sum;
        }
        //run the menu and verify if need to use args or not
        static void RunMenu(string[] args)
        {
            bool isBegan = false;
            bool isContinue = true;
            isBegan = InputSeries(args) ? true : false;

            while (!isBegan)
            {
                isBegan = InputSeries() ? true : false;

            }


            while (isContinue)
            {

                Console.WriteLine(

                    "\n" +
                    "a. Input a Series. (Replace the current series)\n" +
                    "b. Display the series in the order it was entered.\n" +
                    "c. Display the series in the reversed order it was entered.\n" +
                    "d. Display the series in sorted order (from low to high).\n" +
                    "e. Display the Max value of the series.\n" +
                    "f. Display the Min value of the series.\n" +
                    "g. Display the Average of the series.\n" +
                    "h. Display the Number of elements in the series.\n" +
                    "i. Display the Sum of the series.\n" +
                    "j. Exit.\n");
            


            char choice = Console.ReadLine()[0];

                switch (choice)
                {
                    case 'a':
                        Console.Write("\nInput a series of numbers: ");
                        InputSeries();
                        break;
                    case 'b':
                        Console.Write("\nYour series in order: ");
                        Display(series);
                        break;
                    case 'c':
                        Console.Write("\nYour series in reverse: ");
                        List<int> reversed = ToReverse(series);
                        Display(reversed);
                        break;
                    case 'd':
                        Console.Write("\nYour series sorted: ");
                        List<int> sorted = ToSorted(series);
                        Display(sorted);
                        break;
                    case 'e':
                        Console.Write("\nThe max is series: ");
                        int max = FindMax(series);
                        Display(max);
                        break;
                    case 'f':
                        Console.Write("\nThe min is series: ");
                        int min = FindMin(series);
                        Display(min);
                        break;
                    case 'g':
                        Console.Write("\nThe average is: ");
                        double average = FindAverage(series);
                        Display(average);
                        break;
                    case 'h':
                        Console.Write("\nThe legth of the series is: ");
                        int length = FindLength(series);
                        Display(length);
                        break;
                    case 'i':
                        Console.Write("\nThe sum of the series is: ");
                        int sum = FindSum(series);
                        Display(sum);
                        break;
                    case 'j':
                        isContinue = false;
                        break;
                    default:
                        Console.Write("\n choice not exist\n");
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
