﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Solution (1): Hello, World!");
Console.WriteLine("");

string stg = "Hello, World!";
Console.WriteLine("Solution (2): " + stg);
Console.WriteLine("");


Console.WriteLine("Enter username: ");
string userName = Console.ReadLine();
Console.WriteLine("The user's name is:" + userName);
Console.WriteLine("");

Console.WriteLine("Enter the user's age: ");
//int age = COnvert.ToInt32(Console.Readline());
int age = int.Parse(Console.ReadLine());
Console.WriteLine("The user's age is: " + age);


