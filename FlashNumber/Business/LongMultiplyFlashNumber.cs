using System;
using System.Linq;
using System.Text;

namespace FlashNumber.Business
{
    internal class LongMultiplyFlashNumber : FlashNumberBusinessBase<int>
    {
        public LongMultiplyFlashNumber()
        {
            FlashBusinessName = "Long Multiply";        
            NoOfDigitsEnabled = false;
            NoOfDigits = 4;
            NoOfTimes = 2;
            NoOfTimesEnabled = false;
        }


        public override void GenerateRanges()
        {
            MinNumber = 1;
            int multiple = NoOfDigits > 1 ? 1000 : 0;
            MaxNumber = 9 + (9 * multiple);
        }

        public override string CalculateResult()
        {
            long product = 1;
            FlashedNumbers.ForEach(x => product *= x);
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
