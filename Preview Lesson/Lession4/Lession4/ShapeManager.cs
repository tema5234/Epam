using System;
using System.Collections.Generic;

namespace Lession4
{
	/// <summary>
	/// Класс управления фигурами
	/// </summary>
	public class ShapeManager
	{
		private Circle _circle;
		private Rectangle _rectangle;
		private Triangle _triangle;
		private List<Shape2D> _shapes2D;

		//Определяем конструктор класса
		public ShapeManager()
		{
			//Создаем обьекты:
			_circle = new Circle();
			_rectangle = new Rectangle();
			_triangle = new Triangle();

			//создаем список фигур (Коллекцию) и заполняем его нашими обьектами
			_shapes2D = new List<Shape2D>();
			_shapes2D.Add(_circle);
			_shapes2D.Add(_rectangle);
			_shapes2D.Add(_triangle);
		}

		// <summary>
		/// Метод вывводит информацию о круге
		/// </summary>
		private void PrintCircleInfo()
		{
			Console.WriteLine(_circle.Name);
			Console.WriteLine("x1: " + _circle.x1);
			Console.WriteLine("y1: " + _circle.y1);
			Console.WriteLine("Радиус: " + _circle.radius);
			_circle.Draw();
			_circle.Square();
			Console.WriteLine();
		}

		/// <summary>
		/// Метод вывводит информацию о прямоугольнике
		/// </summary>
		private void PrintRectangleInfo()
		{
			Console.WriteLine(_rectangle.Name);
			Console.WriteLine("X1: " + _rectangle.x1);
			Console.WriteLine("Y1: " + _rectangle.y1);
			Console.WriteLine("X2: " + _rectangle.x2);
			Console.WriteLine("Y2: " + _rectangle.y2);
			_rectangle.Draw();
			_rectangle.Square();
			Console.WriteLine();
		}

		/// <summary>
		/// Метод вывводит информацию о треуголнике
		/// </summary>
		private void PrintTriangleInfo()
		{
			Console.WriteLine(_triangle.Name);
			Console.WriteLine("X1: " + _triangle.x1);
			Console.WriteLine("Y1: " + _triangle.y1);
			Console.WriteLine("X2: " + _triangle.x2);
			Console.WriteLine("Y2: " + _triangle.y2);
			Console.WriteLine("X3: " + _triangle.x3);
			Console.WriteLine("Y3: " + _triangle.y3);
			_triangle.Draw();
			_triangle.Square();
			Console.WriteLine();
		}

		/// <summary>
		/// Метод выводит общую информацию для всех наследников,
		/// находящихся в списке фигур
		/// </summary>
		private void PrintShapes2DInfo()
		{
			foreach (var shape in _shapes2D)
			{
				Console.WriteLine(String.Format("{0} будет нарисован на '{1}'...", shape.Name, shape.Paper));
				shape.Draw();
				Console.WriteLine();
			}
		}

		public void Run()
		{
			PrintCircleInfo();
			PrintRectangleInfo();
			PrintTriangleInfo();
			PrintShapes2DInfo();
		}
	}
}
