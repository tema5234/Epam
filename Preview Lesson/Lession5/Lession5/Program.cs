namespace Lession5
{
	#region Usings
	using System;
	using System.Collections.Generic;
	#endregion

	#region MiInterface
	public interface IMyInterface
	{
		string ReadFile(string fileName);

		void SaveFile(string fileName, string textInFile);
	}
	#endregion


	public class Program
	{

		#region Private Methods
		private static void ConversionTextInList(string textInFile, List<Person> fileCollection)
		{
			string[] array = textInFile.Split(';');
			foreach (string n in array)
			{
				string[] arrayWorker = n.Split(' ');

				if ((n != null) && (n != ""))
				{
					Person worker = new Person();
					worker.id = int.Parse(arrayWorker[0]);
					worker.surname = arrayWorker[1];
					worker.name = arrayWorker[2];
					worker.age = int.Parse(arrayWorker[3]);
					worker.phoneNumber = arrayWorker[4];
					fileCollection.Add(worker);
				}
			}
		}

		private static string ConversionListInText(List<Person> fileCollection)
		{
			string writableText = null;
			foreach (Person workers in fileCollection)
			{
				writableText = writableText + "\r\n" + workers.ToString();
			}
			return writableText;
		}

		#endregion

		static void Main(string[] args)
		{
			#region Variables
			string textInFile;
			string writableText;
			string fileName = "Workers.txt";
			int optionMenu;
			#endregion

			#region Menu
			Console.WriteLine("Menu:");
			Console.WriteLine("1  Read\\Saving the file using the class 'File'.");
			Console.WriteLine("2  Read\\Saving the file using the class 'FileStream'.");
			Console.WriteLine("3  Read\\Saving the file using the class 'Stream Reader, Stream Writer'.");
			Console.Write("Select option:");
			try
			{
				optionMenu = int.Parse(Console.ReadLine());
			}
			catch
			{
				optionMenu = 5;
			}
			#endregion

			switch (optionMenu)
			{
				case 1:
					{
						#region Using class File
						Console.Clear();
						Console.WriteLine("Open with the class 'File'");

						string sortFileName = "sort_" + fileName;

						ClassFile workersAcrossF = new ClassFile();
						var fileCollection = new List<Person>();

						Console.WriteLine("Initial data in file:");
						textInFile = workersAcrossF.ReadFile(fileName);
						Console.WriteLine(textInFile);
						ConversionTextInList(textInFile, fileCollection);

						Console.WriteLine("End data in new file ({0}):", sortFileName);
						writableText = ConversionListInText(fileCollection);
						Console.WriteLine(writableText);
						workersAcrossF.SaveFile(sortFileName, writableText);
						break;
						#endregion
					}
				case 2:
					{
						#region Using class FileStream
						Console.Clear();
						Console.WriteLine("Open with the class 'FileStream'");

						string sortFileNameFS = "sortFS_" + fileName;

						ClassFileStream workersAcrossFS = new ClassFileStream();
						var fileCollectionFS = new List<Person>();

						Console.WriteLine("Initial data in file:");
						// ?? textInFile = null;
						textInFile = workersAcrossFS.ReadFile(fileName);
						Console.WriteLine(textInFile);
						ConversionTextInList(textInFile, fileCollectionFS);

						Console.WriteLine("End data in new file ({0}):", sortFileNameFS);
						// ??writableText = null;
						writableText = ConversionListInText(fileCollectionFS);
						Console.WriteLine(writableText);
						workersAcrossFS.SaveFile(sortFileNameFS, writableText);
						break;
						#endregion
					}
				case 3:
					{
						#region Using class StreamReader\StreamWriter
						Console.Clear();
						Console.WriteLine("Open with the class 'StreamReader'and save with the 'StreamWriter'");

						string sortFileNameSRW = "sortFSRW_" + fileName;
						ClassStreamReaderWriter workersAcrossSRW = new ClassStreamReaderWriter();
						var fileCollectionSRW = new List<Person>();

						Console.WriteLine("Initial data in file:");
						//?? textInFile = null;
						textInFile = workersAcrossSRW.ReadFile(fileName);
						Console.WriteLine(textInFile);
						ConversionTextInList(textInFile, fileCollectionSRW);

						Console.WriteLine("End data in new file ({0}):", sortFileNameSRW);
						//??writableText = null;
						writableText = ConversionListInText(fileCollectionSRW);
						Console.WriteLine(writableText);
						workersAcrossSRW.SaveFile(sortFileNameSRW, writableText);
						break;
						#endregion
					}
				default:
					{
						Console.WriteLine("!!! Incorrect option. the program is closed...");
						break;
					}
			}
			Console.ReadKey();
		}
	}
}
