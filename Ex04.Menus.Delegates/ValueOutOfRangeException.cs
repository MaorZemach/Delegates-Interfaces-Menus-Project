using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class ValueOutOfRangeException : InvalidOperationException
    {
        private float m_MaxInputValueRange;
        private float m_MinInputValueRange;
        private const string m_OutOfRangeExceptionMsg = "Invalid input. The input value is not an integer in the the range of {0} to {1}.";

        private float MinValue
        {
            get
            {
                return this.m_MinInputValueRange;
            }
            set
            {
                this.m_MinInputValueRange = value;
            }
        }

        private float MaxValue
        {
            get
            {
                return this.m_MaxInputValueRange;
            }
            set
            {
                this.m_MaxInputValueRange = value;
            }
        }

        public ValueOutOfRangeException(float i_MinRangeValue, float i_MaxRangeValue) : base(string.Format(m_OutOfRangeExceptionMsg, i_MinRangeValue, i_MaxRangeValue))
        {
            MinValue = i_MinRangeValue;
            MaxValue = i_MaxRangeValue;
        }
    }
}