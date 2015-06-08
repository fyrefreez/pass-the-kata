using System.Collections.Generic;
using System.Globalization;

namespace FizzPop
{
    public class FizzPopper
    {
        public IEnumerable<string> Range(int from, int to)
        {
            for (int i = from; i <= to; i++)
            {
                yield return this[i];
            }
        }

        public string this[int i] 
        {
            get
            {
                string result = i.ToString(CultureInfo.InvariantCulture);
                if (i%7 == 0)
                {
                    result = "Fizz";
                }
                if (i.ToString().IndexOf('9') > 0)
                {
                    result = "Pop";
                }
                if (i%7 == 0 && i%9 == 0)
                {
                    result = "FizzPop";
                }
                if (result == i.ToString(CultureInfo.InvariantCulture))
                    return i.ToString(CultureInfo.InvariantCulture);
                else return result;
            }
        }
    }
}
