char Mark;

Console.WriteLine("Please, Enter a Mark!");

Mark = Convert.ToChar(Console.ReadLine().ToUpper());

if (Mark == 'A')
{
    Console.WriteLine("Suurepärane!");
}
else if (Mark == 'B')
{
    Console.WriteLine("Väga hea!");
}
else if (Mark == 'C')
{
    Console.WriteLine("Hea!");
}
else if (Mark == 'D')
{
    Console.WriteLine("Rahuldav");
}
else if (Mark == 'E')
{
    Console.WriteLine("Kasin");
}
else if (Mark == 'F')
{
    Console.WriteLine("Puudulik");
}
else
{
    Console.WriteLine("vale väärtus");
}