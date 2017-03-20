using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibrary1
{
    class ListOfResistance
    {
        /// <summary>
        /// Класс для сериализации листа
        /// </summary>
        [XmlRoot]
        public class ListFigure
        {
            /// <summary>
            /// лист сданными о фигурах
            /// </summary>
            public ListOfIMathCount ListOfResistanceMath { get; set; }
        }

    }
}
