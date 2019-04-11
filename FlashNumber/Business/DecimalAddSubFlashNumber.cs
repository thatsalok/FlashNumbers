using System;
using System.Linq;
using System.Text;

namespace FlashNumber.Business
{
    internal class DecimalAddSubFlashNumber : FlashNumberBusinessBase<double>
    {
        public DecimalAddSubFlashNumber()
        {
            FlashBusinessName = "Decimal Addition and Subratration";
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
            return FlashedNumbers.Sum().ToString("N2");
        }

        public override string GenerateNextNumber()
        {
            int nextNumber = _randomgenerator.Next((int)MinNumber, (int)MaxNumber);
            double precision = nextNumber + _randomgenerator.NextDouble();
            FlashedNumbers.Add(precision);
            return precision.ToString("N2");
        }


        public override string SetOfNumber()
        {
            StringBuilder sb = new StringBuilder();
            FlashedNumbers.ForEach(x => sb.AppendFormat("{0:N2},", x));
            return sb.ToString().TrimEnd(',');
        }
    }
}
