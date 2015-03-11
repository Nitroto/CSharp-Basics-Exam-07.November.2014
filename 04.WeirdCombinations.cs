using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class WeirdCombinations
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string combination = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        char[] elements = new char[combination.Length];
        int counter = 0;
        bool result = false;
        for (int i = 0; i < combination.Length; i++)
        {
            elements[i] = combination[i];
        }
        for (int first = 0; first < elements.Length; first++)
        {
            char a = elements[first];
            for (int second = 0; second < elements.Length; second++)
            {
                char b = elements[second];
                for (int third = 0; third < elements.Length; third++)
                {
                    char c = elements[third];
                    for (int fourth = 0; fourth < elements.Length; fourth++)
                    {
                        char d = elements[fourth];
                        for (int fifth = 0; fifth < elements.Length; fifth++)
                        {
                            char e = elements[fifth];
                            if (counter == n)
                            {
                                Console.WriteLine("" + a + b + c + d + e);
                                result = true;
                            }
                            counter++;
                        }
                    }
                }
            }
        }
        if (!result)
        {
            Console.WriteLine("No");
        }
    }
}
