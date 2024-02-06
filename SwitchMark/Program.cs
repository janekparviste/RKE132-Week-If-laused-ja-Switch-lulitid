char Mark;

Console.WriteLine("Please, Enter a Mark!");

Mark = Convert.ToChar(Console.ReadLine().ToUpper());

switch(Mark)
{
    case 'A':  
        Console.WriteLine("Suurepärane!");
        break;  
    case 'B':
        Console.WriteLine("Väga hea!");
        break;
    case 'C':
        Console.WriteLine("Hea!");
        break;
    case 'D':
        Console.WriteLine("Rahuldav");
        break;
    case 'E':
        Console.WriteLine("Kasin");
        break;
    case 'F':
        Console.WriteLine(  "Puudulik");
        break;
    default:
        Console.WriteLine("vale väärtus");
        break;
}