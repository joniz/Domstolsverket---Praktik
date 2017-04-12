using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Domstol.Droid
{
	class FileAccessHelper
	{
		public static string GetLocalFilePath(string filename)
		{
			string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			string dbPath = Path.Combine(path, filename);

			updateDatabase(dbPath);
			return dbPath;
		}
		private static void updateDatabase(string dbPath)
		{

			using (var br = new BinaryReader(Application.Context.Assets.Open("Domstol2.db")))
			{
				using (var bw = new BinaryWriter(new FileStream(dbPath, FileMode.Create)))
				{
					byte[] buffer = new byte[2048];
					int length = 0;
					while ((length = br.Read(buffer, 0, buffer.Length)) > 0)
					{
						bw.Write(buffer, 0, length);
					}
				}
			}

		}



	}




}