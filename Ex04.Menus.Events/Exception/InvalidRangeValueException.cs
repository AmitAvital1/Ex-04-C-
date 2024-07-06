using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class InvalidRangeValueException : Exception
    {
        private float MaxValue;
        private float MinValue;
        private string RelevantCriterionInput;

        public InvalidRangeValueException(float i_MinValue, float i_MaxValue, string i_RelevantCriterionInput)
        {
            MinValue = i_MinValue;
            MaxValue = i_MaxValue;
            RelevantCriterionInput = i_RelevantCriterionInput;
        }

        public override string Message
        {
            get
            {
                return string.Format("Value is out of range. {0} value have to be between {1} to {2}",
                    RelevantCriterionInput, MinValue, MaxValue);
            }
        }
    }
}
