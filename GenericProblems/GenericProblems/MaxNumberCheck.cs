using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems
{
    public class MaxNumberCheck<T> where T : IComparable
    {
        public T val1, val2, val3, val4;

        public MaxNumberCheck(T val1, T val2, T val3, T val4)
        {
            this.val1 = val1;
            this.val2 = val2;
            this.val3 = val3;
            this.val4 = val4;
        }

        public static T MaxNumber(T val1, T val2, T val3, T val4)
        {
            if (val1.CompareTo(val2) > 0 && val1.CompareTo(val3) > 0 && val1.CompareTo(val4) > 0)
                return val1;
            if (val2.CompareTo(val1) > 0 && val2.CompareTo(val3) > 0 && val2.CompareTo(val4) > 0)
                return val2;
            if (val3.CompareTo(val1) > 0 && val3.CompareTo(val2) > 0 && val3.CompareTo(val4) > 0)
                return val3;
            if (val4.CompareTo(val1) > 0 && val4.CompareTo(val2) > 0 && val4.CompareTo(val3) > 0)
                return val4;
            return val1;
        }

        public T MaxMethod()
        {
            T max = MaxNumberCheck<T>.MaxNumber(this.val1, this.val2, this.val3, this.val4);
            return max;
        }
    }
}
