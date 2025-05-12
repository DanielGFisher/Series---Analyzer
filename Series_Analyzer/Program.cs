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
                Verify(list);
                Menu(NewSeries(list));
                
            }
        }

        public static void Menu(List<string> list)
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
                    Console.WriteLine(SeriesMax(list));
                    break;

                case 6 when choice == 6:
                    Console.WriteLine(SeriesMin(list));
                    break;

                case 7 when choice == 7:
                    SeriesAverage(list);
                    break;

                case 8 when choice == 8:
                    Console.WriteLine(SeriesSum(list));
                    break;

                case 9 when choice == 9:
                    ExitProgram();
                    break;
            }

        }

        public static void Verify(List<string> list)
        {
            int count = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (int.Parse(list[i]) > 0) count += 1;
            }
            if (count >= 3)
            {
                Console.WriteLine("Verified Successfully!");
                flagMain = false;
            }
            else Console.WriteLine("Inputs are invalid!");
        }

        public static List<string> NewSeries(List<string> list)
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
                            list.Add(num);
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
                if (i == list.Count - 1) Console.Write(list[i]);
                else Console.Write(list[i] + ",");
            }
        }


        public static void ReverseOrder(List<string> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (i == 0) Console.Write(list[i]);
                else Console.Write(list[i] + ",");
            }
        }

        public static void SortedOrder(List<string> list)
        {

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


    

