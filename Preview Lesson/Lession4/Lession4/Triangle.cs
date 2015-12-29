using System;

namespace Lession4
{
	/// <summary>
	/// Описывает класс Треугольник - наследованый от класса фигуры 2D.
	/// </summary>
	public class Triangle : Shape2D
	{
		public int x1;
		public int y1;
		public int x2;
		public int y2;
		public int x3;
		public int y3;

		public Triangle()
		{
			//Координаты левого верхнего и правого нижнего углов прямоугольника.
			x1 = 1;
			y1 = 1;
			x2 = 1;
			y2 = 4;
			x3 = 6;
			y3 = 1;
		}

		//Переписываем базовое свойство Имя с помощь. "Override"
		public override string Name
		{
			get { return "Треугольник"; }
		}

		//Переопределяем базовый метод Рисовать.
		public override void Draw()
		{
			Console.WriteLine(String.Format("Рисуем треугольник X1,Y1:({0},{1}); X2,Y2:({2},{3}); X3,Y3:({4},{5});", x1, y1, x2, y2, x3, y3));
		}

		public override void Square()
		{
			double sideA = Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*y2-y1));
			double sideB = Math.Sqrt(((x3-x2)*(x3-x2))+((y3-y2)*y3-y2));
			double sideC = Math.Sqrt(((x3-x1)*(x3-x1))+((y3-y1)*y3-y1));
			double p = (sideA+sideB+sideC)/2;
			double square =Math.Sqrt(p*((p-sideA)*(p*sideB)*(p-sideC)));
			Console.WriteLine(String.Format("Площадь треугольника равна = {0}", square));
		}
	}
}