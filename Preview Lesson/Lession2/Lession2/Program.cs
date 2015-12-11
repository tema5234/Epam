﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Работа с циклами

namespace Lession2
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Lession 2 :  Task 1.");

            //  написать алгоритм решения циклической задачи вычисления значения функции в зависимости от значения переменной 
            //  аргумента. значения переменной аргумента должны изменяться от начального до конечного с заданным шагом.
            // Выражение: Y = 2.23X^2 + 3.12X - 1.95
            // Начальное значение: -0.25
            // Конечное значение: 1.75
            // Значение шага: 0.05


            //Определяем входные параметры
            Console.WriteLine("Enter the first value");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the final value");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the step value");
            double h = Convert.ToDouble(Console.ReadLine());

            //Вычисление значения функции

            Console.WriteLine("Result");
            for (double X = A; X <= B; X = X + h)
            {
                double Y = 2.23 * X * X + 3.12 * X - 1.95;
                Console.Write(Y + " ");
            }

            Console.ReadLine();

            //--------------------------------------------------------------------------------------------------------------------
            //Дано целое N>0. Найти сумму 1+1/2+1/3+...+1/N
            Console.WriteLine("Lession 2 :  Task 2.");

            Console.WriteLine("Enter N (must be int and  > 0)");
            int N = Convert.ToInt16(Console.ReadLine());
            double RezTask2 = 0;
            int Schetchik = 1;
            while (Schetchik != N)
            {
                RezTask2 = RezTask2 + 1 / Schetchik;
                Schetchik = Schetchik + 1;
            }
            Console.WriteLine("The rezult of calculattion : " + RezTask2);
            Console.ReadLine();


            //--------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Lession 2 :  Task 3.");
            //Начальный вклад в банке равен 1000000 руб. Через каждый месяц размер вклада увеличивается на Р процентов 
            //от имеющейся суммы. Р - вещественное число 0<P<25. По данному Р определить, через сколько месяцев размер 
            //вклада превысит 1100000 руб. и вывести найденное количество месяцев K (целое число) и итоговый размер 
            //вклада S (вещественное число).

            Console.WriteLine("Сумма вклада 1000000 руб");
            decimal SumVklada = 1000000;   //S
            Console.WriteLine("Введите процентную ставку (от 0% до 25%)");
            int ProcVklada = Convert.ToInt16(Console.ReadLine());
            
            int KolMesVklada = 0; //K

            do
            {
                KolMesVklada = KolMesVklada + 1;
                SumVklada = SumVklada + SumVklada / 100 * ProcVklada;
            }
            while (SumVklada <= 1100000);

            Console.WriteLine(" Через " + KolMesVklada + " мес. сумма вклада превысит 1100000 и станет равной : " + SumVklada);
            Console.ReadLine();


        }
    }
}
