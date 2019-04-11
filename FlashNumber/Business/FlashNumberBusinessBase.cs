using System;
using System.Collections.Generic;

namespace FlashNumber.Business
{
    public interface IFlashNumbers
    {
        void GenerateRanges();
        string GenerateNextNumber();
        string CalculateResult();
        bool CheckAnswer(string enteredAnswer);
        string SetOfNumber();
        bool GetNextNumber(out string nextNumber);

        void Reset();


        int NoofAttempt { get; set; }        
        int NoOfDigits { get; set; }
        int NoOfTimes { get; set; }
        int Intervals { get; set; }
        string FlashBusinessName { get; set; }
        bool NoOfTimesEnabled { get; set; }
        bool NoOfDigitsEnabled { get; set; }
        bool ShowConfigurationDialog { get; set; }
    }


    public abstract class FlashNumberBusinessBase<T> : IFlashNumbers where T : struct
    {
        #region public
        public int NoOfDigits { get; set; }
        public int NoOfTimes { get; set; }
        public int Intervals { get; set; }
        public int NoofAttempt { get; set; }
        public bool NoOfTimesEnabled { get; set; }
        public bool NoOfDigitsEnabled { get; set; }
        public string FlashBusinessName { get; set; }
        public bool ShowConfigurationDialog { get; set; }
        #endregion


        #region private
        //internal int _noOfAttempts { get; set; }
        internal Random _randomgenerator { get; set; }

        internal T MinNumber { get; set; }
        internal T MaxNumber { get; set; }
        internal List<T> FlashedNumbers { get; set; }

        #endregion

        public FlashNumberBusinessBase()
        {
            FlashedNumbers = new List<T>();
            NoofAttempt = 0;
            _randomgenerator = new Random((int)(DateTime.Now.Ticks / 10000));
            ShowConfigurationDialog = true;
            NoOfTimesEnabled = true;
            NoOfDigitsEnabled = true;
        }

        public void Reset()
        {
            NoofAttempt = 0;
            FlashedNumbers = new List<T>();
        }


        public bool GetNextNumber(out string nextNumber)
        {
            nextNumber = null;
            if (++NoofAttempt > NoOfTimes) return false;
            nextNumber = GenerateNextNumber();
            return true;
        }

        public  bool CheckAnswer(string enteredAnswer)
        {
            string result = CalculateResult();
            return string.Compare(result, enteredAnswer) == 0;
        }

        public abstract void GenerateRanges();
        public abstract string GenerateNextNumber();
        public abstract string CalculateResult();
        public abstract string SetOfNumber();
    }
}
