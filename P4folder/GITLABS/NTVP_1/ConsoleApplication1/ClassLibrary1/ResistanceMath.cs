using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// Класс резистивного метода
    /// </summary>
  public  class ResistanceResCalc : MathCount
    {
          private double _resistanceValue; 
    
  
      /// <summary>
      /// Конструктор для реализации метода расчёта сопротивления резистора 
      /// </summary>
      /// <param name="ResistanceIn"></param>
      public ResistanceResCalc(double ResistanceIn)
        {
         _resistanceValue = ResistanceIn;
        }
        //метод расчёта сопротивления резистора       
            public double ResistanceCalculation
        {
            get
            {

                return (_resistanceValue);
            }
        }
      }
    }

