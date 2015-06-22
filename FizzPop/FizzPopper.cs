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
                if (i % 7 == 0 && result.IndexOf('9') > 0)
                {
                    return "FizzPop";
                }
                if (result.IndexOf('9') > 0)
                {
                    return "Pop";
                }
                if (i % 7 == 0)
                {
                    return "Fizz";
                }
                return result;
            }
        }
    }
}
