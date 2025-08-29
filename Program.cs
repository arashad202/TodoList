﻿
//Console.WriteLine("Provide a number");
//string userInput = Console.ReadLine();
//int number = int.Parse(userInput);
//Console.WriteLine(number);

Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

switch (userChoice)
{
    case "S":
    case "s":
        PrintSelectedOption("See all TODOs");
        break;
    case "A":
    case "a":
        PrintSelectedOption("Add a TODO");
        break;
    case "R":
    case "r":
        PrintSelectedOption("Remove a TODO");
        break;
    case "E":
    case "e":
        PrintSelectedOption("Exit");
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}

//if (userChoice == "S")
//{
//    PrintSelectedOption("See all TODOs");
//}
//else if (userChoice == "A")
//{
//    PrintSelectedOption("Add a TODO");
//}
//else if (userChoice == "R")
//{
//    PrintSelectedOption("Remove a TODO");
//}
//else if (userChoice == "E")
//{
//    PrintSelectedOption("Exit");
//}


Console.ReadKey(); // preventing window closing

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}
