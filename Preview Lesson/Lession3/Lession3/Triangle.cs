namespace Lession3
{
	#region Usings
	using System;
	#endregion

	/// <summary>
	/// Class triangle
	/// </summary>
	public class Triangle : Shape2DHelper
	{
		#region Properties
		/// <summary>
		/// Variables - sides of triangle.
		/// </summary>
		public double a { get; set; }
		public double b { get; set; }
		public double c { get; set; }
		#endregion

		#region Constructors
		/// <summary>
		/// Defolt konstructor
		/// </summary>
		public Triangle()
		{
		}

		/// <summary>
		/// Constructor with parameters.
		/// </summary>
		/// <param name="a">4</param>
		/// <param name="b">5</param>
		/// <param name="c">7</param>
		public Triangle(double a, double b, double c)
		{
			this.a = a;
			this.b = b;
			this.c = c;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Override the function GetSquare()
		/// </summary>
		/// <returns>Math.Sqrt(p * (p - a) * (p - b) * (p - c))</returns>
		public override double GetSquare()
		{
			double p = (a + b + c) / 2;
			return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
		}

		/// <summary>
		/// Override the function GetPerimeter()
		/// </summary>
		/// <returns>a + b + c</returns>
		public override double GetPerimeter()
		{
			return a + b + c;
		}

		#endregion
	}
}
