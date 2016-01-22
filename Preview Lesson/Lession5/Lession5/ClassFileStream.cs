namespace Lession5
{
	#region Usings
	using System;
	using System.Text;
	using System.IO;
	#endregion

	class ClassFileStream : IMyInterface
	{
		private byte[] arrayFile;
		string textInFile;

		#region Public methods
		public string ReadFile(string fileName)
		{
			try
			{
				using (FileStream fileFS = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read))
				{
					arrayFile = new byte[fileFS.Length];
					fileFS.Read(arrayFile, 0, arrayFile.Length);
					textInFile = Encoding.UTF8.GetString(arrayFile);
					textInFile = textInFile.Remove(0, 1);
					return (textInFile);
				}
			}
			catch
			{
				textInFile = null;
				Console.WriteLine("File '{0}' is not found or not opened", fileName);
				return textInFile;
			}
		}

		public void SaveFile(string fileName, string textFromFile)
		{
			try
			{
				using (FileStream fileFS = new FileStream(fileName, FileMode.OpenOrCreate))
				{
					arrayFile = Encoding.Default.GetBytes(textFromFile);
					fileFS.Write(arrayFile, 0, arrayFile.Length);
				}
			}
			catch
			{
				Console.WriteLine("Warning!!! File don't saved...");
			}
		}
		#endregion 
	}
}
