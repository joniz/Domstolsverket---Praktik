using System;
using System.IO;
using Foundation;

namespace Domstol.iOS
{
	public class FileAccessHelper
	{
		public static string GetLocalFilePath(string filename) 
		{

			//string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			//string libFolder = System.IO.Path.Combine(docFolder, "..", "Library");

			//if (!System.IO.Directory.Exists(libFolder)) 
			//{
  			//System.IO.Directory.CreateDirectory(libFolder);
			//}

			//return System.IO.Path.Combine(libFolder, filename);


			string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

			if (!Directory.Exists (libFolder)) 
			{
				Directory.CreateDirectory (libFolder);
			}

			string dbPath = Path.Combine(libFolder, filename);

			overWriteDb(dbPath);


			return dbPath;
		
		}
		private static void overWriteDb(string dbPath)
		{
			
				var existingDb = NSBundle.MainBundle.PathForResource("Domstol2", "db");
				File.Delete(dbPath);
				File.Copy(existingDb, dbPath);

		}
	}
}
