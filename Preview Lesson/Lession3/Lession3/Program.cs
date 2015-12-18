using System;

namespace Lession3
{
	public abstract class Shape2DHelper
	{
		public abstract double GetSquare();
		public abstract double GetPerimeter();
	}
	public class Rectangle:Shape2DHelper
	{
		double a, b;
		public Rectangle (double a, double b)
		{
			this.a = a;
			this.b = b;
		}
		public override double GetSquare()
		{
			return a*b;
		}
		public override double GetPerimeter()
		{
			return (a+b)*2;
		}
	}
	public class Square : Rectangle
	{
		double sideSquare;
		public Square(double sideSquare):base(sideSquare,sideSquare)
		{
			this.sideSquare = sideSquare;
		}
		public override double GetSquare()
		{
			return sideSquare*sideSquare;
		}
	}
	public class Triangle : Shape2DHelper
	{
		double a, b, c;
		public Triangle(double a, double b, double c)
		{
			this.a = a;
			this.b = b;
			this.c = c;
		}
		public override double GetSquare()
		{
			double p = (a + b + c) / 2;
			return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
		}
		public override double GetPerimeter()
		{
			return a+b+c;
		}
	}

	public class TestMyProgram
	{
		public static void Main()
		{
			Shape2DHelper shapeRectangle = new Rectangle(2, 4);
			double square = shapeRectangle.GetSquare();
			double perimeter = shapeRectangle.GetPerimeter();
			Console.WriteLine("Rectangle: Square - " + square+" ;    perimeter - "+perimeter);

			Shape2DHelper shapeSquare = new Square(8);
			square = shapeSquare.GetSquare();
			perimeter = shapeSquare.GetPerimeter();
			Console.WriteLine("Square: Square - " + square + " ;    perimeter - " + perimeter);
			
			Shape2DHelper shapeTriangle = new Triangle(4, 5, 6);
			square = shapeTriangle.GetSquare();
			perimeter = shapeTriangle.GetPerimeter();
			Console.WriteLine("Triangle: Square - " + square + " ;    perimeter - " + perimeter);
			Console.ReadLine();
		}
	}
}