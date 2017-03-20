using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     public interface IMathCount
    {
         double ResistanceCalculation
         {
            get;
         }
         string ElementType
         {
             get;
         }

         double[] Parametr
         {
             get;
         }
    }
}
