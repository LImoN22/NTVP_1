using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CapacityResCalc : IMathCount
    {
       public double CapacityValue;
       public double FrequencyValue;


       /// <summary>
        /// Пустой конструктор для сериализации 
       /// </summary>
       /// <param name="CapacityIn"></param>
       /// <param name="FrequencyIn"></param>
       public CapacityResCalc() {}

        
/*        public CapacityResCalc()
        {

            // TODO: Complete member initialization
        }
        */
        //метод расчёта сопротивления конденсатора 
        public double ResistanceCalculation
        {
            get
            {
                return (1/(2 * System.Math.PI * FrequencyValue * CapacityValue));
            }
        }
        public string ElementType
        {
            get
            {
                return "Capasitor resistance";
            }
        }
        public double[] Parametr
        {
            get
            {
                double[] p = { Math.Round(CapacityValue, 3), Math.Round(FrequencyValue, 3) };
                return p;
            }
        }
    }   
}
