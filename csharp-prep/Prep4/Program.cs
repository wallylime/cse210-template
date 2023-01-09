using System;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        /*
        After checking the solution, I realized that I wasn't supposed to do this the easy way :).
        I originally had this:
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number in the list is: {numbers.Max()}");
        */
        int sum = 0;
        int max = 0;
        foreach (int n in numbers)
        {
            sum+=n;
            if (n > max)
            {
                max = n;
            }
        }
        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
   }
}