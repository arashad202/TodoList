
Console.WriteLine("Provide a number");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);
Console.WriteLine(number);

Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

int a = 4, b = 2, c = 10;
Console.WriteLine($"First is {a} Second is {b} Third is {c}");


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

//void PrintSelectedOption (string selectedOption)
//{
//    Console.WriteLine("Selected option: " + selectedOption);
//}
