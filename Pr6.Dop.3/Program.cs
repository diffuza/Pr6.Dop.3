using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // *** Расчет стоимости капиталовложения с ***
            // *** фиксированной нормой прибыли***
            decimal money, percent; //присвоение локальным переменным "money", "percent" десетичного типа "decimal"
            int i; //присвоение лок.переменной i целочисленного типа "int"
            const byte years = 15; // присвоение лок.переменной "years" неизменяемого типа "bite"

            money = 1000.0m; // преставление десятичное число с плавающей запятой.
            percent = 0.045m;// преставление десятичное число с плавающей запятой.

            for (i = 1; i <= years; i++) //применения цикла "for".
            {
                money *= 1 + percent;
            }

            Console.WriteLine("Общий доход за {0} лет: {1} $$", years, money); //Вывод строки "..." с вычисленными данными на экран на экран.
            Console.ReadLine(); //считывание следующей строки символов из стандартного входного потока.
        }
    }
}
