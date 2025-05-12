bool flag = true;
void Main()
{

}

void Menu()
{
    Console.WriteLine("--- Menu ---");
    Console.WriteLine("1) Insert New Series:\n2) Display Current Order\n3) Display Reversed Order:\n4) Display Sorted Order:\n5) Display Largest Series Value:\n6) Display Lowest Series Value:\n7) Display Series Average:\n8) Display Series Sum:\n9) Exit Program:");
    Console.WriteLine("Please Insert Choice by number:");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            NewSeries();
            break;

        case 2:
            CurrentOrder();
            break;

        case 3:
            ReverseOrder();
            break;

        case 4:
            SortedOrder();
            break;

        case 5:
            SeriesMax();
            break;

        case 6:
            SeriesMin();
            break;

        case 7:
            SeriesAverage();
            break;

        case 8:
            SeriesSum();
            break;

        case 9:
            ExitProgram();
            break;
    }

}

void Verify()
{

}

void NewSeries()
{

}

void CurrentOrder()
{

}

void ReverseOrder()
{

}

void SortedOrder()
{

}

void SeriesMax()
{

}

void SeriesMin()
{

}

void SeriesAverage()
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