namespace Lession3
{
	public class Square : Rectangle
	{
		#region Properties
		public double sideSquare { get; set; }
		#endregion

		#region Constructors
		public Square()
		{
		}

		public Square(double sideSquare)
			: base(sideSquare, sideSquare)
		{
			this.sideSquare = sideSquare;
		}
		#endregion
	}
}
