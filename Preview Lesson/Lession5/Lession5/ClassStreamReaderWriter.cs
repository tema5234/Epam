namespace Lession5
{
	#region Usings
	using System;
	using System.Text;
	using System.IO;
	#endregion


	class ClassStreamReaderWriter : IMyInterface
	{
		private string textInFile;

		#region Public methods
		public string ReadFile(string fileName)
		{
			try
			{
				using (StreamReader fileStr = new StreamReader(fileName, Encoding.Default))
				{
					textInFile = fileStr.ReadToEnd();
					return textInFile;
				}
			}
			catch
			{
				textInFile = null;
				Console.WriteLine("File '{0}' is not found or not opened", fileName);
				return textInFile;
			}
		}

		public void SaveFile(string fileName, string textInFile)
		{
			try
			{
				using (StreamWriter fileStr = new StreamWriter(fileName, true, Encoding.Default))
				{
					fileStr.Write(textInFile);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		#endregion
	}
}
