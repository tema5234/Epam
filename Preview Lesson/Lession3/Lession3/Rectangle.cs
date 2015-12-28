namespace Lession3
{
	public class Rectangle : Shape2DHelper
	{
		#region Properties
		public double a { get; set; }
		public double b { get; set; }
		#endregion

		#region Constructors
		public Rectangle()
		{
		}

		public Rectangle(double a, double b)
		{
			this.a = a;
			this.b = b;
		}
		#endregion

		#region Public Methods
		public override double GetSquare()
		{
			return a * b;
		}

		public override double GetPerimeter()
		{
			return (a + b) * 2;
		}
		#endregion
	}
}
