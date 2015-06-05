using System.Globalization;

namespace FizzPop
{
    public class FizzPopper
    {
        public string this[int i] 
        {
            get
            {
                string result = i.ToString(CultureInfo.InvariantCulture);
                if (i%7 == 0)
                {
                    result = "Fizz";
                }
                if (i%9 == 0)
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
