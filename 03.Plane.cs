using System;

class Plane
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        int spacesBefore = (n + n / 2);
        byte spacesMiddle = 1;
        Console.Write(new string('.',spacesBefore));
        Console.Write('*');
        Console.Write(new string('.', spacesBefore));
        Console.WriteLine();
        spacesBefore--;
        for (int i = 0; i < (n/2+2); i++)
        {
            Console.Write(new string('.', spacesBefore));
            Console.Write('*');
            Console.Write(new string('.', spacesMiddle));
            Console.Write('*');
            Console.Write(new string('.', spacesBefore));
            Console.WriteLine();
            spacesBefore--;
            spacesMiddle += 2;
        }
        spacesBefore--;
        spacesMiddle += 2;
        for (int i = 0; i < n/2-1; i++)
        {

            Console.Write(new string('.', spacesBefore));
            Console.Write('*');
            Console.Write(new string('.', spacesMiddle));
            Console.Write('*');
            Console.Write(new string('.', spacesBefore));
            Console.WriteLine();
            spacesBefore -= 2;
            spacesMiddle += 4;
        }
        spacesBefore = (n / 2 + (n / 2 - 1));
        Console.Write('*');
        Console.Write(new string('.', spacesBefore));
        Console.Write('*');
        Console.Write(new string('.', n));
        Console.Write('*');
        Console.Write(new string('.', spacesBefore));
        Console.Write('*');
        Console.WriteLine();
        spacesMiddle = 1;
        for (int i = 0; i < n / 2-1; i++)
        {
            spacesBefore -= 2;
            Console.Write('*');
            Console.Write(new string('.', spacesBefore));
            Console.Write('*');
            Console.Write(new string('.', spacesMiddle));
            Console.Write('*');
            Console.Write(new string('.', n));
            Console.Write('*');
            Console.Write(new string('.', spacesMiddle));
            Console.Write('*');
            Console.Write(new string('.', spacesBefore));
            Console.Write('*');
            Console.WriteLine();
            spacesMiddle+=2;
        }
        spacesBefore = n - 1;
        spacesMiddle = n;
        for (int i = 0; i < n-1; i++)
        {
            Console.Write(new string('.', spacesBefore));
            Console.Write('*');
            Console.Write(new string('.', spacesMiddle));
            Console.Write('*');
            Console.Write(new string('.', spacesBefore));
            Console.WriteLine();
            spacesMiddle += 2;
            spacesBefore--;
        }
        Console.WriteLine(new string('*', 3*n));
    }
}
