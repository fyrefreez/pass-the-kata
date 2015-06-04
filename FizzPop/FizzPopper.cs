namespace FizzPop
{
    public class FizzPopper
    {
        public string this[int i] 
        {
            get
            {
                string result = "";
                if (i%7 == 0)
                {
                    result = "Fizz";
                }
                if (i%9 == 0)
                {
                    
                }
                return i.ToString();
            }
        }
    }
}
