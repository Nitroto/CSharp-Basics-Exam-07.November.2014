using System;

namespace OddOrEvenCounter
{
    class OddOrEvenCounter
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            byte c = byte.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            bool odd = false;
            int[,] numbers = new int[n, c];
            int[] countOfNumbers = new int[n];
            int counter = 0;
            string[] ordinal = new string[] { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth" };
            if (s == "odd")
            {
                odd = true;
            }
            if (odd)
            {
                for (int i = 0; i < n; i++)
                {
                    counter = 0;
                    for (int j = 0; j < c; j++)
                    {
                        numbers[i, j] = Int32.Parse(Console.ReadLine());
                        if (numbers[i, j] % 2 > 0)
                        {
                            counter++;
                        }
                    }
                    countOfNumbers[i] = counter;
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    counter = 0;
                    for (int j = 0; j < c; j++)
                    {
                        numbers[i, j] = Int32.Parse(Console.ReadLine());
                        if (numbers[i, j] % 2 == 0)
                        {
                            counter++;
                        }
                    }
                    countOfNumbers[i] = counter;
                }
            }
            int position = 0;
            int bigestValue = 0;
            for (int i = 0; i < n; i++)
            {
                if (countOfNumbers[i] > bigestValue && countOfNumbers[i]!=0)
                {
                    position = i;
                    bigestValue = countOfNumbers[i];
                }
            }
            string oddOrEven="even";
            if (odd)
            {
                oddOrEven = "odd";
            }
            if (bigestValue != 0)
            {
                Console.WriteLine("{0} set has the most {1} numbers: {2}", ordinal[position], oddOrEven, bigestValue);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
