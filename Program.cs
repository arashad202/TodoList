string word;
do
{
    Console.WriteLine("Enter a word longer than 10 letters");
    word = Console.ReadLine();

} while (word.Length <= 10);

Console.WriteLine("The loop is finished");


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


