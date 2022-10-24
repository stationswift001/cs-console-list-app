// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
		ConsoleKeyInfo cki;
        List<string> list = new List<string>();
        //into and instructions
        Console.WriteLine("Welcome to the list!");
        Console.WriteLine("Type something and press enter to add it!");
		cki = Console.ReadKey();
        if((cki.Modifiers & ConsoleModifiers.Alt) = 0)    {
		string latestTest = Console.ReadLine();
        //Console.WriteLine(latestTest);
        list.Add(latestTest);
        Console.WriteLine("Added!")
        }
		foreach(String item in list){
			Console.WriteLine((list.IndexOf(item) + 1) + ": " + item);
            
		}
    }
}
