

namespace SeriesAnalyser
{
    class Program
    {



       static List<int> series = new List<int>();


        static bool InputSeries()
        {
            string seriesInString = Console.ReadLine();
            return verifySeries(seriesInString);
        }
        static bool verifySeries(string input)
        {
            string currentNum = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 49 && input[i] <= 57)
                {
                    currentNum += input[i];
                    continue;
                }
                else if (input[i] == ' ')
                {
                    series.Add(int.Parse(currentNum));
                    currentNum = "";
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return series.Count >=3?true:false;
            
        }
        static void Display(List<int> series) {
            foreach (int num in series)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
        }
        static void Display(int num) {
            Console.WriteLine(num);
        }
        static List<int> ToReverse(List<int> series) { return series; }
        List<int> ToSorted(List<int> series) { return series; }
        static int FindMax(List<int> series) { return 1; }
        static int FindMin(List<int> series) { return 1; }
        static int FindAverage(List<int> series) { return 1; }
        static int FindLength(List<int> series) { return 1; }
        static int FindSum(List<int> series) { return 1; }

        public void RunMenu()
        {
            InputSeries();
            bool isContinue = true;

            while (isContinue)
            {
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

                switch (choice)
                {
                    case 'a':
                        Console.WriteLine("Input a series of numbers: ");
                        InputSeries();
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



        }
    }



}
