using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CapacityResCalc : MathCount
    {
        private double _capacityValue;
        private double _frequencyValue;


       /// <summary>
        /// Конструктор для реализации метода расчёта сопротивления катушки индуктивности 
       /// </summary>
       /// <param name="CapacityIn"></param>
       /// <param name="FrequencyIn"></param>
        public CapacityResCalc(double CapacityIn, double FrequencyIn)
        {
            _capacityValue = CapacityIn;
            _frequencyValue = FrequencyIn;

        }

        //метод расчёта сопротивления конденсатора 
        public double ResistanceCalculation
        {
            get
            {
                return (1/(2 * System.Math.PI * _frequencyValue * _capacityValue));
            }
        }
        public string ElementType
        {
            get
            {
                return "Capasitor resistance";
            }
        }
    }   
}
