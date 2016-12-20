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



        public CapacityResCalc(double CapacityIn, double FrequencyIn)
        {
            _capacityValue = CapacityIn;
            _frequencyValue = FrequencyIn;

        }
        public double Calculation
        {
            get
            {
                return (1/(2 * System.Math.PI * _frequencyValue * _capacityValue));
            }
        }
    }   
}
