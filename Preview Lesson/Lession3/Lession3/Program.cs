// -----------------------------------------------------------------------
// <copyright file="Lession3.cs" company="EPAM, System.">
// Copyright (c) One Call Care Management, Inc. All rights reserved.
// </copyright>
// <remarks>
// Задача: 1) Определить расчет площади и периметра для 2-умерных фигур 
// 2) переделать задачу через свойства, вместо конструкторов
// 3) Доделать в задаче возможность расчетов обьемов для 3-х мерных фигур, на основе исходных.
// </remarks>
// -----------------------------------------------------------------------

namespace Lession3
{
	#region Usings
	using System;
	#endregion

	/// <summary>
	/// 
	/// </summary>
	public class TestMyProgram
	{
		#region Public Method
		/// <summary>
		/// Calling functions and calculation of results
		/// </summary>
		public static void Main()
		{
			/// <summary>
			/// 2D - Perimeter and Square
			/// </summary>
			Shape2DHelper shapeRectangle = new Rectangle(4, 6);
			double square = shapeRectangle.GetSquare();
			double perimeter = shapeRectangle.GetPerimeter();
			Console.WriteLine("Rectangle: Square - " + square + " ;    perimeter - " + perimeter);

			Shape2DHelper shapeSquare = new Square(8);
			square = shapeSquare.GetSquare();
			perimeter = shapeSquare.GetPerimeter();
			Console.WriteLine("Square: Square - " + square + " ;    perimeter - " + perimeter);

			Shape2DHelper shapeTriangle = new Triangle(4, 5, 7);
			square = shapeTriangle.GetSquare();
			perimeter = shapeTriangle.GetPerimeter();
			Console.WriteLine("Triangle: Square - " + square + " ;    perimeter - " + perimeter);

			///<summary>
			///3D - Volume (for Parallelepiped and Cube).
			///</summary>

			double sideA = 2;
			double sideB = 3;
			double sideC = 4;
			Rectangle shapeParallelepiped = new Parallelepiped(sideA, sideB, sideC);
			square = shapeParallelepiped.GetSquare();
			double volumeParallelepiped = square * sideC;
			Console.WriteLine();
			Console.WriteLine("Площадь стороны параллелепипеда (2,3,4) равна = " + square);
			Console.WriteLine("Объем параллелепипеда (2,3,4) равна = " + volumeParallelepiped);

			sideA = 2;
			Shape2DHelper shapeSquareVolume = new Square(sideA);
			square = shapeSquareVolume.GetSquare();
			double volumeCube = square * sideA;

			Console.WriteLine();
			Console.WriteLine("Площадь стороны куба (2,2,2) равна = " + square);
			Console.WriteLine("Объем куба (2,2,2) равна = " + volumeCube);
			Console.ReadLine();
		}
		#endregion
	}
}