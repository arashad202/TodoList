char[,] letters = new char[2, 3];

letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';

var height = letters.GetLength(0);
var width = letters.GetLength(1);

for (int i = 0; i < height; i++)
{
    Console.WriteLine($"i is {i}");
    for (int j = 0; j < width; j++)
    {
        Console.WriteLine($"J is {j}");
        Console.WriteLine($"Element is {letters[i, j]}");
    }
}

var letters2 = new char[,]
{
    { 'A', 'B', 'C' },
    { 'D', 'E', 'F' },
};


//Console.WriteLine("Hello!");
//Console.WriteLine("[S]ee all TODOs");
//Console.WriteLine("[A]dd a TODO");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");

//var userChoice = Console.ReadLine();

//switch (userChoice)
//{
//    case "S":
//    case "s":
//        PrintSelectedOption("See all TODOs");
//        break;
//    case "A":
//    case "a":
//        PrintSelectedOption("Add a TODO");
//        break;
//    case "R":
//    case "r":
//        PrintSelectedOption("Remove a TODO");
//        break;
//    case "E":
//    case "e":
//        PrintSelectedOption("Exit");
//        break;
//    default:
//        Console.WriteLine("Invalid input");
//        break;
//}

//void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine("Selected option: " + selectedOption);
//}



Console.ReadKey(); // preventing window closing


