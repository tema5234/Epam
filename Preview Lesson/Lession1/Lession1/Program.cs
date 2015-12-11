using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;



namespace Lession1
//Задача: по введенному N, где N - это количество элементов массива, рандомно заполнить массив и отсортировать его в зависимости от параметра 
//isDesc = (true|false) (DESC сортирует от высоких значений к низким).
//Входные параметры: N - int, isDesc - bool.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of array elements, please");
            int N = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("select the sorting method (1 - ascending, 2 - descending)");
            int[] array = new int[N];
            Random rand = new Random();
            for (int i = 0; i < N;  i++)
            {
                array[i] = rand.Next(0,20);
            }
            
            bool isDesc;
            int isD = Convert.ToInt16(Console.ReadLine());
            if (isD == 1)
            {
                isDesc = true;
                for (int i=0; i<N; i++)
                    for (int j = i + 1; j < N; j++)
                    if (array[i]>array[j])               
                    {
                      int temp = array[i];
                      array[i] = array[j];
                      array[j] = temp;
                    }
            }
            else if (isD == 0)
            {
                isDesc = false;
                for (int i = 0; i < N; i++)
                    for (int j = i + 1; j < N; j++)
                        if (array[i] < array[j])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
            }
            else
            {
                Console.WriteLine("You have entered an invalid value (default is accept 0)");
            }


            for (int i = 0; i < N; i++)
            {
                Console.Write(array[i]+" ");
            }

            Console.ReadLine();
        
        }




    }
}
