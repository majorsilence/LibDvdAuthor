using System;
using LibDvdAuthor;

namespace DvdAuthorTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			DvdAuthor a = new DvdAuthor();
			
			Titles b = new Titles(a.XmlDoc);
			Titles c = new Titles(a.XmlDoc);
			
			b.AddFile("/hello/world.mpg");
			b.AddFile("/hello/world/version2.mpg");
			
			c.AddFile("/big/buck/bunny.mpg");
			c.AddFile("/big/world/version2.mpg");
			
			a.AddTitle(b.GetTitle());
			a.AddTitle(c.GetTitle());
			
			a.Save(@"C:\Documents and Settings\Peter\Desktop\test.xml");
			
			Console.WriteLine ("Hello World!");
		}
	}
}

