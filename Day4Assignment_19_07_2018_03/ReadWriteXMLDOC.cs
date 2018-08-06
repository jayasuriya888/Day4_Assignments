using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Day4Assignment_19_07_2018_03
{
    class ReadWriteXMLDOC
    {
        List<PartInfo> plist = new List<PartInfo>();
       public  ReadWriteXMLDOC()
        {
            plist.Add(new PartInfo{Item = "Mother Board",Manufacture = "ASUS",Model = "P3B-F",Cost = 123.00});
            plist.Add(new PartInfo { Item = "Video Card", Manufacture = "A-T-I", Model = "All In Wonder Pro", Cost = 126.00 });
            plist.Add(new PartInfo { Item = "Sound Card", Manufacture = "Creative Labs", Model = "Blaster Live", Cost = 80.00 });
            plist.Add(new PartInfo { Item = "inch Monitor", Manufacture = "LG Electronics", Model = "995E", Cost = 290.00 });
        }

        public void writeXMLDOC()
        {
            XmlWriter write = XmlWriter.Create(@"C:\files\partxml.xml");
            write.WriteStartDocument();
            write.WriteStartElement("Parts");
            foreach(var d in plist)
            {
                write.WriteStartElement("Part");
                write.WriteElementString("Item",d.Item);
                write.WriteElementString("Manufacture", d.Manufacture);
                write.WriteElementString("Model", d.Model);
                write.WriteElementString("Cost", d.Cost.ToString());
                write.WriteEndElement();
            }
            write.WriteEndElement();
            write.WriteEndDocument();
            write.Close();

            Console.WriteLine("XML File has been written Successfully!!!");
        }

        public void readXMLDOC()
        {
            XElement xele = XElement.Load(@"C:\files\bin\partxml.xml");
            var data1 = xele.Elements();
            foreach (var d in data1)
                Console.WriteLine(d);
            Console.WriteLine("**********************************************************************************");


           
        }

    }
}
