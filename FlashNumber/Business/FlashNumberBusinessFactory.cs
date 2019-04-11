namespace FlashNumber.Business
{
    internal class FlashNumberBusinessFactory
    {
        static internal IFlashNumbers GetFlashNumbersObject(FormTypes formTypes)
        {
            switch (formTypes)
            {
                case FormTypes.Addition:
                    return new AdditionFlashNumber();
                case FormTypes.AdditionSubration:
                    return new AddSubFlashNumber();

                case FormTypes.DecimalAddSub:
                    return new DecimalAddSubFlashNumber();

                case FormTypes.Multiply:
                    return new MultiplyFlashNumber();
                case FormTypes.LongMultiply:
                    return new LongMultiplyFlashNumber();
                case FormTypes.Division:
                    return new DivisionFlashNumber();
                default:
                    break;
            }

            return null;
        }
    }
}
