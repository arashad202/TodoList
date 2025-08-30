//List<string> words = new List<string>();
var words = new List<string> { "one", "two" };

//Console.WriteLine($"Count of elements is {words.Count}");


words.AddRange(new[] { "three", "four", "five" });

Console.WriteLine("Removing an element");
//words.Remove("two");
words.RemoveAt(0);

foreach (var word in words)
{
    Console.WriteLine(word);
}



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


