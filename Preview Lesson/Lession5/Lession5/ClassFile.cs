namespace Lession5
{
	#region Usings
	using System;
	using System.IO;
	#endregion

	public class ClassFile : IMyInterface
	{
		private string textInFile;

		#region Public methods
		public string ReadFile(string fileName)
		{
			try
			{
				Console.WriteLine("File '{0}' is oppened:", fileName);
				textInFile = File.ReadAllText(fileName);
				return textInFile;
			}
			catch
			{
				textInFile = null;
				return textInFile;
			}
		}

		public void SaveFile(string fileName, string textInFile)
		{
			try
			{
				File.WriteAllText(fileName, textInFile);
			}
			catch
			{
				Console.WriteLine("File '{0}' is not found or not opened", fileName);
			}
		}
		#endregion
	}
}
