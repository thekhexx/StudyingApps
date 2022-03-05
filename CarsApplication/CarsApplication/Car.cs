using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarsApplication
{
    //Организовать ввод, хранение в файле, вывод на экран данных о машинах:
    //    модель, цвет, фамилия владельца, номер, год выпуска.
    //    Вывести на экран данные обо всех машинах по введенному году выпуска.
    //    Определить количество машин, имеющих цвет на букву «С».
    public class Car
    {

        [XmlElement(ElementName = "Model")]
        public string Model { get; set; }

        [XmlElement(ElementName = "Color")]
        public string Color { get; set; }

        [XmlElement(ElementName = "OwnerSurname")]
        public string OwnerSurname { get; set; }

        [XmlElement(ElementName = "Number")]
        public string Number { get; set; }

        [XmlElement(ElementName = "Year")]
        public string Year { get; set; }
    }
}
