using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
  public  class ResistanceResCalc : MathCount
    {
          private double _resistanceValue; 
    
  
      
            public ResistanceResCalc(double ResistanceIn)
            {
            _resistanceValue = ResistanceIn;
            }

            
     

        //методы        
        public double Calculation
        {
            get
            {

                return (_resistanceValue);
            }
        }
        

        }

    }
}
