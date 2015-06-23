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
                string result = string.Empty;
                result += i % 7 == 0 ? "Fizz" : string.Empty;
                result += i.ToString().Contains("9") ? "Pop" : string.Empty;
                return result == string.Empty ? i.ToString() : result;
            }
        }
    }
}
