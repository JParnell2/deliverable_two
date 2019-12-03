using System;

public class Program
{
    public static void Main()
    {
        var input = "";
        string message = null;
        int checksum = 0;

        Console.WriteLine("What is your message?");
        input = Console.ReadLine();
        input = input.ToUpper();

        foreach (char c in input)
        {
            if (message != null)
                message += "-";
            else
                message = "";
            message += c - 64;
            checksum += c;
        }

        Console.WriteLine(message);
        Console.WriteLine(checksum);

    }
}