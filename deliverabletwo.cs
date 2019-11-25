using System;

public class Program
{
    public static void Main()
    {
        string message;
        Console.WriteLine("what is your message?");
        message = Console.ReadLine();
        Console.WriteLine("{0}", message.ToUpper());
        Console.ReadLine();

    }
}