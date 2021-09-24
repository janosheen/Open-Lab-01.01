using System;

namespace Open_Lab_01._01
{
    public class Exercise
    {
        public bool IsLessThan10(string input)
        {
            int res;
            Int32.TryParse(input, out res);
            if (res < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
