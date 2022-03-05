using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace BooksApp
{
    [XmlTypeAttribute(AnonymousType = true)]
    public class BooksData
    {
        [XmlElement("Book")]
        public List<Book> Books { get; set; }
        public BooksData()
        {
            Books = new List<Book>();
        }

        public List<Book> GetBooks()
        {

            string xml = System.IO.File.ReadAllText(@"Books.xml");
            var serializer = new XmlSerializer(typeof(BooksData), new XmlRootAttribute("Books"));
            using (var stringReader = new StringReader(xml))
            using (var reader = XmlReader.Create(stringReader))
            {
                var result = (BooksData)serializer.Deserialize(reader);
                return result.Books;
            }

        }
        public void SaveBooks(List<Book> books)
        {

            string filePath = "Books.xml";

            XmlDocument xmlDoc = new XmlDocument();
            XPathNavigator nav = xmlDoc.CreateNavigator();
            using (XmlWriter writer = nav.AppendChild())
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Book>), new XmlRootAttribute("Books"));
                ser.Serialize(writer, books); 
            }
            File.WriteAllText(filePath, xmlDoc.InnerXml);
        }
    }

   
}
