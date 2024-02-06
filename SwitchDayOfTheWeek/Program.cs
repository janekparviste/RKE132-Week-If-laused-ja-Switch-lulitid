//int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //0 -6
int weekDay = 10;

switch (weekDay) //väärtus, mida kontrollitakse
{
    case 0: //case 0: == if(weekDay == 0)
        Console.WriteLine("It's Sunday!");
        break;
    case 1: //case 1: == if(weekDay == 1)
        Console.WriteLine("It's Monday!");
        break;
    case 2: //case 2: == if(weekDay == 2)
        Console.WriteLine("It's Tuesday!");
        break;
    case 3: //case 3: == if(weekDay == 3)
        Console.WriteLine("It's Wednesday!");
        break;
    case 4: //case 4: == if(weekDay == 4)
        Console.WriteLine("It's Thursday!");
        break;
    case 5: //case 5: == if(weekDay == 5)
        Console.WriteLine("It's Friday!");
        break;
    case 6: //case 6: == if(weekDay == 6)
        Console.WriteLine("It's Saturday!");
        break;
    default:
        Console.WriteLine("Your calendar must be broken.");
        break;
}

Console.WriteLine("Have a nice day!");