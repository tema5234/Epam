namespace Lession3
{
	public class Parallelepiped : Rectangle
	{
		public double heightParallelepiped { get; set; }
		public double widthParallelepiped { get; set; }
		public double longParallelepiped { get; set; }

		#region Constructors
		/// <summary>
		/// Constructors
		/// </summary>
		public Parallelepiped()
		{
		}

		public Parallelepiped(double heightParallelepiped, double widthParallelepiped, double longParallelepiped)
			: base(heightParallelepiped, widthParallelepiped)
		{
			this.heightParallelepiped = heightParallelepiped;
			this.widthParallelepiped = widthParallelepiped;
			this.longParallelepiped = longParallelepiped;
		}
		#endregion

		//public double GetVolume(double heightParallelepiped, double widthParallelepiped, double longParallelepiped)
		//{ 
		//	return longParallelepiped*GetSquare();
		//}
	}
}
