﻿namespace task7
{
    internal class Program
    {
        static void Main()
        {
            for (int i = 0; i < 5; i++)
{
                try
                {

                Console.WriteLine("Введите два числа");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(a + "/ " +b + " = " +a / b);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Нужно ввести число! ");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Делить на нуль нельзя!");
                }
                catch
                {
                    Console.WriteLine("Какая - то ошибка ");
                }
                finally
                {
                    Console.WriteLine("после try-блока ");
                }
            }
        }
    }
}
