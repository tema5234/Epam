using System;

namespace Lession4
{
	/// <summary>
	/// Описывает класс круг - наследованый от класса фигуры 2D.
	/// </summary>
	public class Circle : Shape2D
	{
		public int x1;
		public int y1;
		public int radius;

		public Circle()
		{
			x1 = 1;
			y1 = 4;
			radius = 3;
		}

		//Переписываем базовое свойство Имя с помощь. "Override"
		public override string Name
		{
			get { return "Круг"; }
		}

		//Переопределяем базовый метод Рисовать.
		public override void Draw()
		{
			Console.WriteLine(string.Format("Рисуем круг с центром X1,Y1:({0},{1}) и радиусом {2}", x1, y1, radius));
		}

		public override void Square()
		{
			double square = Math.PI*radius*radius;
			Console.WriteLine(String.Format("Площадь круга равна = {0}", square));
		}
	}
}

