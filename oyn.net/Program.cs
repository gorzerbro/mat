using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 12, 45, 7, 89, 23, 56, 3 };

        int min = numbers[0];
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
                min = numbers[i];
            if (numbers[i] > max)
                max = numbers[i];
        }

        int result = min * max;
        Console.WriteLine("Eng katta va eng kichik sonlarning ko‘paytmasi: " + result);
    }
}
