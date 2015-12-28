// -----------------------------------------------------------------------
// <copyright file="Lession1.cs" company="EPAM, system.">
// Copyright (c) One Call Care Management, Inc. All rights reserved.
// </copyright>
// <remarks>
// Задача: по введенному N, где N - это количество элементов массива, рандомно заполнить массив и отсортировать его в зависимости от параметра 
// isDesc = (true|false) (DESC сортирует от высоких значений к низким).
// Входные параметры: N - int, isDesc - bool.
// </remarks>
// -----------------------------------------------------------------------

namespace Lession1
{
	#region Usings

	using System;

	#endregion

	/// <summary>
	/// 
	/// </summary>
	public class Program
	{
		#region Constants

		/// <summary>
		/// The number element input parmeter
		/// </summary>
		public const string NumberElementInputParameter = "Enter the number of array elements, please";

		#endregion

		#region Public Method
		/// <summary>
		/// Mains the specified arguments.
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			Console.WriteLine(NumberElementInputParameter);
			int elementNumber = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("select the sorting method (1 - ascending, 2 - descending)");
			int isD = Convert.ToInt16(Console.ReadLine());

			int[] array = GetRandomArray(elementNumber);

			bool isDesc = isD == 2 ? true : false;

			SortingArray(elementNumber, array, isDesc);

			for (int i = 0; i < elementNumber; i++)
			{
				Console.Write(array[i] + " ");
			}

			Console.ReadLine();
		}
		#endregion

		#region Private Methods

		/// <summary>
		/// Gets the random array.
		/// </summary>
		/// <param name="N">The n.</param>
		/// <returns>int[]</returns>
		private static int[] GetRandomArray(int N)
		{
			int[] array = new int[N];
			Random rand = new Random();
			for (int i = 0; i < N; i++)
			{
				array[i] = rand.Next(0, 20);
			}
			return array;
		}

		/// <summary>
		/// Sorting the specified n/
		/// </summary>
		/// <param name="N">n.</param>
		/// <param name="array">The array</param>
		/// <param name="isDesc">if set to</param>
		/// <returns></returns>
		private static bool SortingArray(int N, int[] array, bool isDesc)
		{
			if (isDesc)
			{
				for (int i = 0; i < N; i++)
				{
					for (int j = i + 1; j < N; j++)
					{
						if (array[i] > array[j])
						{
							int temp = array[i];
							array[i] = array[j];
							array[j] = temp;
						}
					}
				}
			}
			else
			{
				for (int i = 0; i < N; i++)
				{
					for (int j = i + 1; j < N; j++)
					{
						if (array[i] < array[j])
						{
							int temp = array[i];
							array[i] = array[j];
							array[j] = temp;
						}
					}
				}
			}
		}
		#endregion
	}
}
