Console.WriteLine("Tal1:");
int Tal1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Tal2:");
int Tal2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(""" 
    What do your what
    Addition - 1
    Subtraction - 2
    Multiplication - 3
    Division - 4
    """);

var Input = GetInput();

switch (Input)
{
    case "1":
        Console.WriteLine(Tal1+Tal2);
        break;
    case "2":
        Console.WriteLine(Tal1 - Tal2);
        break;
    case "3":
        Console.WriteLine(Tal1 * Tal2);
        break;
    case "4":
        Console.WriteLine(Tal1 / Tal2);
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}

string GetInput ()
{
    return Console.ReadLine();
}