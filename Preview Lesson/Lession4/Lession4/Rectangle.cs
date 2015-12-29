using System;

namespace Lession4
{
	/// <summary>
	/// Описывает класс Прямоугольник - наследованый от класса фигуры 2D.
	/// </summary>
	public class Rectangle : Shape2D
	{
		public int x1;
		public int y1;
		public int x2;
		public int y2;

		public Rectangle()
		{
			//Координаты левого верхнего и правого нижнего углов прямоугольника.
			x1 = 1;
			y1 = 4;
			x2 = 6;
			y2 = 1;

		}

		//Переписываем базовое свойство Имя с помощь. "Override"
		public override string Name
		{
			get { return "Прямоугольник"; }
		}

		//Переопределяем базовый метод Рисовать.
		public override void Draw()
		{
			Console.WriteLine(string.Format("Рисуем прямоугольник X1,Y1:({0},{1}); X2,Y2:({2},{3});", x1, y1, x2, y2));
		}

		public override void Square()
		{
			double square = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);
			Console.WriteLine(String.Format("Площадь прямоугольника равна = {0}", square));
		}
	}
}
