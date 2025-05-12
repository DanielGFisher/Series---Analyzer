using System.Collections.Generic;
using System.ComponentModel.Design;

bool flagMain = true;
bool flagMenu = true;

List<int> Main(string[] args)
{
    args.ToList<string>();
    while (flagMain == true)
    {
        Console.WriteLine("--- Welcome to our Analyzer! ---");
        Verify(args);
        NewSeries(args);
    }
}
Menu(args);
void Menu(List<string> list)
{
    Console.WriteLine("--- Menu ---");
    Console.WriteLine("1) Insert New Series:\n2) Display Current Order\n3) Display Reversed Order:\n4) Display Sorted Order:\n5) Display Largest Series Value:\n6) Display Lowest Series Value:\n7) Display Series Average:\n8) Display Series Sum:\n9) Exit Program:");
    Console.WriteLine("Please Insert Choice by number:");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            NewSeries(list);
            break;

        case 2:
            CurrentOrder(list);
            break;

        case 3:
            ReverseOrder(list);
            break;

        case 4:
            SortedOrder(list);
            break;

        case 5:
            SeriesMax(list);
            break;

        case 6:
            SeriesMin(list);
            break;

        case 7:
            SeriesAverage(list);
            break;

        case 8:
            SeriesSum();
            break;

        case 9:
            ExitProgram();
            break;
    }

}

List<string> Verify(List<string> list)
{
    int count = 0;

    for (int i = 0; i < args.Length; i++)
    {
        if (int.Parse(args[i]) > 0) count += 1;
    }
    if (count >= 3) 
    {
        Console.WriteLine("Verified Successfully!");
        flagMain = false;
        return list;
    }
    else Console.WriteLine("Inputs are invalid!");
}

List<string> NewSeries(List<string> list)
{
    foreach (var item in list)
    {
        list.Remove(item);
    }

    bool flag = true;
    while (flag == true)
    {
        Console.WriteLine("--- New Series ---");
        Console.WriteLine("1) Add New Numbers:\n2) Exit:");
        Console.WriteLine("Insert a choice by number:");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Please insert your number:");
                    string num = Console.ReadLine();
                }
                flag = false;
                break;

            case 2:
                flag = false;
                break;

            default:
                Console.WriteLine("Invalid Input!");
                break;
        }
    }
    return list;
}

void CurrentOrder(List<string> list)
{
    foreach (var item in list)
    {
        Console.Write(item + ",");
    }
}

void ReverseOrder(List<string> list)
{
    for (int i = list.Count; list.Count > 0; i--)
    {
        Console.Write(list[i] + ",");
    }
}

void SortedOrder(List<string> list)
{
    
}

int SeriesMax(List<string> list)
{
    int num = 0;
    for (int i = 0; i < list.Count; i++)
    {
        if (int.Parse(list[i]) > num) num = int.Parse(list[i]);
    }
    return num;
}

int SeriesMin(List<string> list)
{
    int num = int.Parse(list[0]);
    for (int i = 0; i < list.Count; i++)
    {
        if (int.Parse(list[i]) < num) num = int.Parse(list[i]);
    }
    return num;
}

void SeriesAverage(string[] list)
{

}

void SeriesSum()
{

}

void ExitProgram()
{

}

void SeriesCount()
{

}