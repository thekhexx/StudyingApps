


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BooksApp
{
    // Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
    
  
    public class Book
    {
        [XmlElement(ElementName = "Surname")]
        public string Surname { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Patronymic")]
        public string Patronymic { get; set; }

        [XmlElement(ElementName = "BookName")]
        public string BookName { get; set; }

        [XmlElement(ElementName = "Address")]
        public string Address { get; set; }

        [XmlElement(ElementName = "Publisher")]
        public string Publisher { get; set; }

        [XmlElement(ElementName = "Year")]
        public string Year { get; set; }


    }
}
