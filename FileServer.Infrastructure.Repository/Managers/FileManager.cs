using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileServer.Infrastructure.Repository.Managers
{
	public class FileManager
	{
		public static bool CreateFile(string Path)
		{
			StreamWriter sw = null;
			bool vRetorno = true;
			try
			{

			}
			catch 
			{
				vRetorno = false;
			}
			finally
			{
				if (sw == null)
					sw.Close();
			}
		}

		public static bool FileExist(string Path)
		{
			return (File.Exists(Path));
		}
	}
}
