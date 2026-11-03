using System;

public class Program
{
    public static void Main()
    {
        var random = new Random();
        int[] arrayNumbers = new int[20];
        int[] arrayNumbersOdd = new int[20];
        int[] arrayNumbersEven = new int[20];



        for (int i = 0; i < arrayNumbers.GetLength(0); i++)
        {
            arrayNumbers[i] = random.Next(1, 100);

            if (arrayNumbers[i] % 2 == 0)
            {
                arrayNumbersEven[i] = arrayNumbers[i];
            }
            else
            {
                arrayNumbersOdd[i] = arrayNumbers[i];
            }
        }
        Console.Write("Numbers even: ");
        foreach (int arrayNumber in arrayNumbersEven)
        {
            if (arrayNumber != 0)
            {
                Console.Write(arrayNumber + " ");
            }
        }
        Console.WriteLine();
        Console.Write("Numbers odd: ");
        foreach (int oddNumbers in arrayNumbersOdd)
        {
            if (oddNumbers != 0)
            {
                Console.Write(oddNumbers + " ");
            }
        }
    }
}