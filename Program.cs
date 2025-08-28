
Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();
bool isLong = IsLong(userChoice);

bool IsLong(string input)
{
    return input.Length > 10;
}

var result = Add(10, 5);
Console.WriteLine("10 + 5 = " + result);

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

int Add(int a, int b)
{
    return a + b;
}