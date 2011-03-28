using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;


// http://dvdauthor.sourceforge.net/doc/x35.html

namespace LibDvdAuthor
{
	public class DvdAuthor
	{
		private FileStream fs;
			
		public DvdAuthor ()
		{
			
					
			//fs = new FileStream(path,FileMode.Open,FileAccess.Read,
	        //                       FileShare.ReadWrite);
			XmlDoc = new XmlDocument();
			//xmldoc.Load(fs);

			
			XmlElement dvd = XmlDoc.CreateElement("dvdauthor");
			XmlDoc.AppendChild(dvd);
			
			XmlElement vmgm = XmlDoc.CreateElement("vmgm");
			dvd.AppendChild(vmgm);
			
			XmlElement titleset = XmlDoc.CreateElement("titleset");
			dvd.AppendChild(titleset);
			
			/*
			XmlElement titles = XmlDoc.CreateElement("titles");
			titleset.AppendChild(titles);
			
			XmlElement pgc = XmlDoc.CreateElement("pgc");
			titles.AppendChild(pgc);
			*/
			
			
		}
		
		
		public XmlDocument XmlDoc { get; set;}
		
		public void Save(string path)
		{
			this.XmlDoc.Save(path);
		}
		
		public void AddTitle(XmlElement title)
		{
			XmlNode node = this.XmlDoc.GetElementsByTagName("titleset")[0];
			
			node.AppendChild(title.Clone());
		}
		
		
		public void Remove(XmlElement element)
		{
			throw new Exception("Not Implmented");
		}
		
		
	}
}

