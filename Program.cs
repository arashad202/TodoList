Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

if (userChoice.Length <= 3)
{
    Console.WriteLine("short answer");
}
else if (userChoice.Length < 10)
{
    Console.WriteLine("medium answer");
}
else
{
    Console.WriteLine("long answer");
}


    Console.ReadKey(); // preventing window closing