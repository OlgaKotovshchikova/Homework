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
                    TaskTen();
                    break;
                case 13:
                    TaskThirteen();
                    break;
                case 15:
                    TaskFifteen();
                    break;
                default:
                    Console.WriteLine("Такой задачи не существует. Введите верную (14, 16, 10, 13 или 15)");
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
            if (number % 7 == 0 && number % 23 == 0)
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
            Console.WriteLine("Введите первое число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            
            if (firstNumber == Math.Pow(secondNumber, 2) || secondNumber == Math.Pow(firstNumber, 2))
                Console.WriteLine("да");
            else
                Console.WriteLine("нет");
        }
        #endregion

        #region Задача 10
        /*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        456 -> 5
        782 -> 8
        918 -> 1*/

        static void TaskTen()
        {
            Console.WriteLine("Введите трехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if ((number >= -999 & number <= -100) || (number >= 100 & number <= 999))
            {
                double twoDigit = number / 10;
                double res = Math.Truncate(twoDigit);
                Console.WriteLine(res % 10);
            }
            else
            {
                Console.WriteLine("Число не трехзначное!");
            }
        }
        #endregion

        #region Задача 13
        /*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        645 -> 5
        78 -> третьей цифры нет
        32679 -> 6*/

        static void TaskThirteen()
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > -99 & number < 99)
            {
                Console.WriteLine("Третьей цифры нет");
            }
            else
            {
                string numberString = number.ToString();
                Console.WriteLine(numberString[2]);
            }
        }
        #endregion

        #region Задача 15
        /*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        6 -> да
        7 -> да
        1 -> нет*/

        static void TaskFifteen()
        {
            Console.WriteLine("Введите номер дня недели: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 & number <= 7)
            {
                if (number == 6 || number == 7)
                    Console.WriteLine("да");
                else Console.WriteLine("нет");
            }
            else
                Console.WriteLine("Такого дня недели не существует");
        }
        #endregion
    }
}
