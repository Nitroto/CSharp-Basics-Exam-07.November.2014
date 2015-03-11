using System;

namespace Budget
{
    class Budget
    {
        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            int p = Int32.Parse(Console.ReadLine());
            int h = Int32.Parse(Console.ReadLine());
            int dayliMoney = 10;
            int normalWeekends = (4 - h) * 2 * (dayliMoney * 2);
            int normalDays = (22 - p) * dayliMoney;
            int partyDays = p * ((int)(n * 0.03) + dayliMoney);
            int rent = 150;
            int endOfMonth = n - normalWeekends - normalDays - partyDays - rent;
            if (endOfMonth > 0)
            {
                Console.WriteLine("Yes, leftover {0}.", endOfMonth);
            }
            else
            {
                if (endOfMonth == 0)
                {
                    Console.WriteLine("Exact Budget.");
                }
                else
                {
                    Console.WriteLine("No, not enough {0}.", Math.Abs(endOfMonth));
                }
            }

        }
    }
}
