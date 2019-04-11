using System;
using System.Linq;
using System.Text;

namespace FlashNumber.Business
{
    internal class AddSubFlashNumber : FlashNumberBusinessBase<int>
    {
        public AddSubFlashNumber()
        {
            FlashBusinessName = "Addition and Subratration";
        }
        public override void GenerateRanges()
        {
            int multiple = NoOfDigits > 1 ? (int)Math.Pow(10, NoOfDigits - 1) : 0;
            int number = 9 + (9 * multiple);
            MinNumber = -1 * number;            
            MaxNumber = number;
        }

        public override string CalculateResult()
        {
            return FlashedNumbers.Sum().ToString();
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
