namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome(123456);
        }

        // x -> array -> ters cevir -> tek tek kontrol et
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var y = x.ToString();

            // "abcd" -> 'a', 'b', 'c', 'd'
            //var reversed = x.ToString().Reverse().ToArray();
            var s = x.ToString();
            var reserved = s.Reverse();
            var reversedY = reserved.ToArray();

            for (int index = 0; index < y.Length; index++)
            {
                if (y[index] != reversedY[index])
                {                  
                    return false;
                }
            }

            return true;
        }
    }
}