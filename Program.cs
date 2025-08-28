Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

if (userChoice.Length > 10)
{
    Console.WriteLine("long answer");
}
else
{
    Console.WriteLine("short answer");
}


    Console.ReadKey(); // preventing window closing