using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1; 

namespace WindowsFormsApplication1
{
   public interface IAddFiguresDelegate
    {
       void DelegateInnerFunc(IMathCount figure);
    }
}
