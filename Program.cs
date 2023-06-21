using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть довжину сторони квадрата:");
        int sideLength = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть символ для відображення квадрата:");
        char symbol = char.Parse(Console.ReadLine());

        DrawSquare(sideLength, symbol);

        Console.ReadLine();
    }

    static void DrawSquare(int sideLength, char symbol)
    {
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
}
