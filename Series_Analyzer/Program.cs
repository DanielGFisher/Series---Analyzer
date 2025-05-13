using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Design;
namespace Project
{
    public class Functions
    {
        static bool flagMain = true;
        static bool flagMenu = true;
        public static void Main(string[] args)
        {

            List<string> list = args.ToList<string>();

            while (flagMain == true)
            {
                Console.WriteLine("--- Welcome to our Analyzer! ---");
                Menu(Validate(NewSeries(list)));

            }
        }

        public static void Menu(List<string> list)
        {
            while (flagMenu == true)
            {
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("1) Insert New Series:\n2) Display Current Order:\n3) Display Reversed Order:\n4) Display Sorted Order:\n5) Display Largest Series Value:\n6) Display Lowest Series Value:\n7) Display Series Average:\n8) Display Series Sum:\n9) Exit Program:");
                Console.WriteLine("Please Insert Choice by number:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1 when choice == 1:
                        NewSeries(list);
                        break;

                    case 2 when choice == 2:
                        CurrentOrder(list);
                        break;

                    case 3 when choice == 3:
                        ReverseOrder(list);
                        break;

                    case 4 when choice == 4:
                        SortedOrder(list);
                        break;

                    case 5 when choice == 5:
                        Console.WriteLine("Maximum:" + SeriesMax(list));
                        break;

                    case 6 when choice == 6:
                        Console.WriteLine("Minimum:" + SeriesMin(list));
                        break;

                    case 7 when choice == 7:
                        SeriesAverage(list);
                        break;

                    case 8 when choice == 8:
                        Console.WriteLine("Sum:" + SeriesSum(list));
                        break;

                    case 9 when choice == 9:
                        ExitProgram();
                        break;
                }

            }
        }


        public static List<string> Validate(List<string> list)
        {
            int count = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (int.TryParse(list[i], out int value) && value > 0) count += 1;
            }
            if (count >= 3)
            {
                Console.WriteLine("Verified Successfully!");
                flagMain = false;
                return list;
            }
            else Console.WriteLine("Inputs are invalid!");
            return NewSeries(list);
        }

        public static List<string> NewSeries(List<string> list)
        { 
            bool flag = true;
            while (flag == true)
            {
                Console.WriteLine("--- New Series ---");
                Console.WriteLine("1) Add New Numbers:\n2) Exit:");
                Console.WriteLine("Insert a choice by number:");
                string initialchoice = Console.ReadLine();
                int choice = 0;

                if (int.TryParse(initialchoice, out int number)) choice = number;
                else Console.WriteLine("Invalid Input");

                    switch (choice)
                    {
                        case 1:
                        list.Clear();
                        for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine("Please insert your number:");
                                string num = Console.ReadLine();
                                list.Add(num);
                            }

                            bool innerflag = true;

                            while (innerflag == true)
                            {
                            Console.WriteLine("1) Add More:\n2) Stop:");
                            string input = Console.ReadLine();
                            int  option = 0;

                            if (int.TryParse(input, out int result)) option = result;
                            else Console.WriteLine("Invalid input!");
                                switch (option)
                                {
                                    case 1 when option == 1:
                                    bool insideFlag = true;

                                    while (insideFlag == true)
                                    {
                                      Console.WriteLine("Please insert your number:");
                                        string num = Console.ReadLine();
                                        if (int.TryParse(num, out int int32))
                                        {
                                            list.Add(num);
                                            insideFlag = false;
                                        }
                                        else Console.WriteLine("Invalid input");
                                     }
                                    break;    
                                     
                                    

                                    case 2 when option == 2:
                                        innerflag = false;
                                        break;

                                    default:
                                        Console.WriteLine("Invalid Input!");
                                        break;
                                }

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
            flagMain = false;
            return list;
        }

        public static void CurrentOrder(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1) Console.WriteLine(list[i]);
                else Console.Write(list[i] + ",");
            }
        }


        public static void ReverseOrder(List<string> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (i == 0) Console.WriteLine(list[i]);
                else Console.Write(list[i] + ",");
            }
        }

        public static void SortedOrder(List<string> list)
        {
            List<int> sortedList = new List<int> { };
            for (int i = 0; i < list.Count; i++)
            {
                int num = int.Parse(list[i]);
                bool inserted = false;

                for (int j = 0; j < sortedList.Count; j++)
                    if (num < sortedList[j])
                    {
                        sortedList.Insert(j, num);
                        inserted = true;
                        break;
                    }
                if (inserted == false) sortedList.Add(num);
            }
            for (int i = 0; i < sortedList.Count; i++)
            {
                if (i == sortedList.Count - 1) Console.WriteLine(sortedList[i]);
                else Console.Write(sortedList[i] + ",");
            }
        }

        public static int SeriesMax(List<string> list)
        {
            int num = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (int.Parse(list[i]) > num) num = int.Parse(list[i]);
            }
            return num;
        }

        public static int SeriesMin(List<string> list)
        {
            int num = int.Parse(list[0]);
            for (int i = 0; i < list.Count; i++)
            {
                if (int.Parse(list[i]) < num) num = int.Parse(list[i]);
            }
            return num;
        }

        public static void SeriesAverage(List<string> list)
        {
            double average = SeriesSum(list) / list.Count;
            Console.WriteLine("Average:" + average);
        }

        public static int SeriesSum(List<string> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += int.Parse(list[i]);
            }
            return sum;
        }

        public static void ExitProgram()
        {
            flagMenu = false;
        }
    }
}