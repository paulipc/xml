using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace xml
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Luetaan xml...");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            XmlDocument doc = new XmlDocument();
            doc.Load(@"c:\temp\bigxml.xml");

            // Get and display all the animals titles.
            XmlElement root = doc.DocumentElement;
            XmlNodeList elemList = root.GetElementsByTagName("animal");
            Console.WriteLine("kpl " + elemList.Count);
            /*for (int i = 0; i < elemList.Count; i++)
            {
                Console.WriteLine(elemList[i].InnerXml);
            }*/

            now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Tiedosto luettu.");
            Console.ReadLine();

        }
    }
}
