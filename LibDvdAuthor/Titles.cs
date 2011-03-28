using System;
using System.Collections.Generic;

using System.Xml;

namespace LibDvdAuthor
{
	public class Titles
	{
		private List<string> filePaths;
		
		private XmlDocument _xmldoc;
		
		private Titles(){}
		
		public Titles (XmlDocument xmldoc)
		{
			filePaths = new List<string>();
			_xmldoc = xmldoc;
		}
		
		
		public void AddFile(string filePath)
		{
			this.filePaths.Add(filePath);
		}
		
		public XmlElement GetTitle()
		{
			
			XmlElement title = _xmldoc.CreateElement("titles");
			
			XmlElement pgc = _xmldoc.CreateElement("pgc");
			title.AppendChild(pgc);
			
			//<vob file="video.mpg" />
			
			foreach ( string s in this.filePaths)
			{
				XmlElement vob = _xmldoc.CreateElement("vob");
				XmlAttribute file = _xmldoc.CreateAttribute("file");

				file.Value = s;
				vob.Attributes.Append(file);
				pgc.AppendChild(vob);
			}
			
			return title;
		}
		
	}
}

