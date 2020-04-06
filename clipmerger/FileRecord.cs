using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clipmerger
{
	class FileRecord
	{
		public string FullFilename { get; set; }
		public string ShortFilename { get; set; }

		public FileRecord(string fullFilename, string shortFilename)
		{
			FullFilename = fullFilename;
			ShortFilename = shortFilename;
		}

		public override string ToString() => ShortFilename;
	}
}
