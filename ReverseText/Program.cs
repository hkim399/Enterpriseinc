// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


namespace ca.bcit;

// using ReverseText;
// using System;
using MyLibrary;

/// this is documentation

public class Booboo {
	public static void Main(String[] args) {
		Console.Write("Please enter your name: ");
		// Scanner scanner = new Scanner(System.in);
		String? name = Console.ReadLine();

        Console.WriteLine(Helper.Reverse(name!));

	}

    // private static string reverse(string s)
    // {
    //     char[] charArray = s.ToCharArray();
    //     Array.Reverse(charArray);
    //     return new string(charArray);
    // }
}
