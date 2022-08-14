using System;

namespace Seminar_09._08
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер задачи (14, 16, 10, 13 или 15): ");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            switch (taskNumber)
            {
                case 14:
                    TaskFourteen();
                    break;
                case 16:
                    TaskSixteen();
                    break;
                case 10:
                    break;
                case 13:
                    break;
                case 15:
                    break;
                default:
                    Console.WriteLine("Такой задачи не существует. Введите верную (14, 16, 10, 13 или 15): ");
                    break;
            }
        }
        #region Задача 14
        /*Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
        14 -> нет
        46 -> нет
        161 -> да*/

        static void TaskFourteen()
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 7 == 0 & number % 23 == 0)
                Console.WriteLine("да");
            else
                Console.WriteLine("нет");
        }
        #endregion

        #region Задача 16
        /*Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
        5, 25 -> да
        -4, 16 -> да
        25, 5 -> да
        8,9 -> нет*/

        static void TaskSixteen()
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 7 == 0 & number % 23 == 0)
                Console.WriteLine("да");
            else
                Console.WriteLine("нет");
        }
        #endregion
    }
}
