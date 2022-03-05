using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace CarsApplication
{
    [XmlTypeAttribute(AnonymousType = true)]
    public class CarsSource
    {
        
        
            [XmlElement("Car")]
            public List<Car> Cars { get; set; }
            public CarsSource()
            {
                Cars = new List<Car>();
            }

            public List<Car> LoadCars()
            {

                string xml = System.IO.File.ReadAllText(@"Cars.xml");
                var serializer = new XmlSerializer(typeof(CarsSource), new XmlRootAttribute("Cars"));
                using (var stringReader = new StringReader(xml))
                using (var reader = XmlReader.Create(stringReader))
                {
                    var result = (CarsSource)serializer.Deserialize(reader);
                    return result.Cars;
                }

            }
            public void SaveCars(List<Car> cars)
            {

                string filePath = "Cars.xml";

                XmlDocument xmlDoc = new XmlDocument();
                XPathNavigator nav = xmlDoc.CreateNavigator();
                using (XmlWriter writer = nav.AppendChild())
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Car>), new XmlRootAttribute("Cars"));
                    ser.Serialize(writer, cars);
                }
                File.WriteAllText(filePath, xmlDoc.InnerXml);
            }
        
    }
}
