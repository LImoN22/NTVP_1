using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
  
  public  class InductResCalc : IMathCount
    {
    public double InductanceValue; 
    public double FrequencyValue;
  
    /// <summary>
    ///пустой конструктор для сериализации 
    /// </summary>
    /// <param name="InductionIn"></param>
    /// <param name="FrequencyIn"></param>
    public InductResCalc() {} 

        //метод расчёта сопротивления катушки индуктивности       
        public double ResistanceCalculation
         {
            get
            {
                return (2 * System.Math.PI * FrequencyValue * InductanceValue);
            }
         }
      public string ElementType
        {
          get
            {
                return "Coil Induction";
            }
        }
      public double[] Parametr
      {
          get
          {
              double[] p = { Math.Round(InductanceValue, 3), Math.Round(FrequencyValue, 3) };
              return p;
          }
      }
       }
}

