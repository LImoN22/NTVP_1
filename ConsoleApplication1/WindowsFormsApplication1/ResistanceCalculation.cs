using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibrary1; 

namespace WindowsFormsApplication1
{
    class ResistanceCalculation
    {
        private int _elementType; 
        private BindingList<TextBox> _textBoxList = new BindingList<TextBox>();
        private IMathCount _iMathCount = null; 
        public ResistanceCalculation(BindingList<TextBox> textBoxList, int elementType)
        {
            _textBoxList = textBoxList ;
            _elementType = elementType ; 
        }

        public IMathCount ResistanceCalculator()
        {
            try
            {
                int i = 0;
                double[] parametrs = null;
                foreach (var textbox in _textBoxList)
                {
                    i++;
                    parametrs[i] = InspectionParametrs.Parametr(textbox.Text, textbox.Name);
                }


                switch (_elementType)
                {
                    case 0:
                        {
                            _iMathCount = new CapacityResCalc
                            {
                                CapacityValue = parametrs[0],
                                FrequencyValue = parametrs[1]
                            };
                            break;
                        }
                    case 1:
                        {
                            _iMathCount = new InductResCalc
                            {
                                InductanceValue = parametrs[0],
                                FrequencyValue = parametrs[1]
                            };
                            break;
                        }
                    case 2:
                        {
                            _iMathCount = new ResistanceResCalc
                            {
                                ResistanceValue = parametrs[0]
                            };
                            break;
                        }
                    default: break;
                }
                return _iMathCount;
            }
            catch (Exception) { return null; }
        }
      
    }
}
