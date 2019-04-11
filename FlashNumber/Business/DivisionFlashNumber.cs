using System;
using System.Linq;
using System.Text;

namespace FlashNumber.Business
{
    internal class DivisionFlashNumber : FlashNumberBusinessBase<int>
    {
        public DivisionFlashNumber()
        {
            FlashBusinessName = "Division";        
            NoOfDigitsEnabled = true;
            NoOfDigits = 2;
            NoOfTimes = 2;
            NoOfTimesEnabled = false;
            
        }


        public override void GenerateRanges()
        {
            MinNumber = 1;
            int multiple = NoOfDigits > 1 ? (int)Math.Pow(10, NoOfDigits - 1) : 0;
            MaxNumber = 9 + (9 * multiple);
        }

        public override string CalculateResult()
        {
            long product = FlashedNumbers[0]/ FlashedNumbers[1];            
            return product.ToString();
        }

        public override string GenerateNextNumber()
        {
            int nextNumber = _randomgenerator.Next(MinNumber, MaxNumber);
            FlashedNumbers.Add(nextNumber);
            return nextNumber.ToString();
        }


        public override string SetOfNumber()
        {
            StringBuilder sb = new StringBuilder();
            FlashedNumbers.ForEach(x => sb.AppendFormat("{0},", x));
            return sb.ToString().TrimEnd(',');
        }
    }
}
