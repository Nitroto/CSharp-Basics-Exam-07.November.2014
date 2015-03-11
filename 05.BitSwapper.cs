using System;
using System.Globalization;
using System.Threading;

class BitSwapper
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        long[] numbers = new long[4];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }
        bool run = true;
        while (run)
        {
            string[] firstCommand = Console.ReadLine().Split(' ');
            if (firstCommand[0] == "End")
            {
                run = false;
            }
            else
            {
                string[] secondCommand = Console.ReadLine().Split(' ');
                int firstNum = int.Parse(firstCommand[0]);
                int secondNum = int.Parse(secondCommand[0]);
                int firstHalfWord =bitChooser(int.Parse(firstCommand[1]));
                int secondHalfWord = bitChooser(int.Parse(secondCommand[1]));
                if (firstHalfWord > secondHalfWord)
                {
                    long firstFourBits = maskGenerator(firstHalfWord) & numbers[firstNum];
                    long secondFourBits = maskGenerator(secondHalfWord) & numbers[secondNum];
                    numbers[firstNum] = (~maskGenerator(firstHalfWord) & numbers[firstNum]) | (secondFourBits << (firstHalfWord - secondHalfWord));
                    numbers[secondNum] = (~maskGenerator(secondHalfWord) & numbers[secondNum]) | (firstFourBits >> (firstHalfWord - secondHalfWord));
                }
                else
                {
                    long firstFourBits = maskGenerator(firstHalfWord) & numbers[firstNum];
                    long secondFourBits = maskGenerator(secondHalfWord) & numbers[secondNum];
                    numbers[firstNum] = (~maskGenerator(firstHalfWord) & numbers[firstNum]) | (secondFourBits >> (secondHalfWord - firstHalfWord));
                    numbers[secondNum] = (~maskGenerator(secondHalfWord) & numbers[secondNum]) | (firstFourBits << (secondHalfWord - firstHalfWord));
                }
            }


        }
        foreach (long num in numbers)
        {
            Console.WriteLine(num);
        }

        }
    private static int bitChooser(int command)
    {
        int bit =0;
        switch (command)
        {
            case 0: bit = 0; break;
            case 1: bit = 4; break;
            case 2: bit = 8; break;
            case 3: bit = 12; break;
            case 4: bit = 16; break;
            case 5: bit = 20; break;
            case 6: bit = 24; break;
            case 7: bit = 28; break;
        }

        return bit;
    }
    private static long maskGenerator(int mask)
    {
        long num=0;
        for (int i = 0; i < 4; i++)
        {
            num = num << 1 | 1;
        }
        num <<= mask;
        return num;
    }
}
