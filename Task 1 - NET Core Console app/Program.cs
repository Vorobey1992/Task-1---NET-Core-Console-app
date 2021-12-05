using System;
using Task_2___Hello_for_task_1_v2_;

class MainClass
{
    public static void Main(string[] args)
    {
        /*Console.WriteLine("Please enter your name:");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello {name}");*/
        HelloMessage helloMessage = new HelloMessage();
        helloMessage.Print();
        Console.ReadLine();
    }
}

