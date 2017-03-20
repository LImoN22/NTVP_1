using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
  public  class ResistanceResCalc : IMathCount
    {
       public double ResistanceValue; 
    
  
      /// <summary>
      /// Пустой конструктор для сериализации 
      /// </summary>
      /// <param name="ResistanceIn"></param>
       public ResistanceResCalc() {}
       
        //метод расчёта сопротивления резистора       
            public double ResistanceCalculation
        {
            get
            {

                return (ResistanceValue);
            }

        }
            public string ElementType
        {
            get
            {
                return "Resistor";
            }
        }
            public double[] Parametr
            {
                get
                {
                    double[] p = { Math.Round(ResistanceValue, 3) };
                    return p;
                }
            }
     }
  }

