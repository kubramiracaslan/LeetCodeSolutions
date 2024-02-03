
namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[3] { 3, 2, 4 };
            var target = 6;

            var output = TwoSum(nums, target);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }

        private const int ARRAY_LEN_MIN = 2;
        private const int ARRAY_LEN_MAX = 10000;
        private const int TARGET_MIN_VAL = -1000000000;
        private const int TARGET_MAX_VAL = 1000000000;
        private const int ARRAY_ITEM_MIN_VAL = TARGET_MIN_VAL;
        private const int ARRAY_ITEM_MAX_VAL = TARGET_MAX_VAL;

        /// <summary>
        /// Checks whether the value is between min and max
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min">Minimum value</param>
        /// <param name="max"></param>
        /// <returns>True if it is between them</returns>
        private static bool IsBetween(int value, int min, int max)
        {
            return value >= min && value <= max;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            if (!IsBetween(nums.Length, ARRAY_LEN_MIN, ARRAY_LEN_MAX))
            {
                return new int[2];
            }

            if (!IsBetween(target, TARGET_MIN_VAL, TARGET_MAX_VAL))
            {
                return new int[2];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!IsBetween(nums[i], ARRAY_ITEM_MIN_VAL, ARRAY_ITEM_MAX_VAL))
                {
                    return new int[2];
                }

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }

            return new int[2];
        }

        #region 1.yol - yanlis           
        //int index1 = 0;
        //int index2 = 0;
        //foreach (int number1 in nums)
        //{                
        //    foreach (var number2 in nums)
        //    {                    
        //        var output = number1 + number2;
        //        if (output == target)
        //        {
        //            result[0] = index1;
        //            result[1] = index2;
        //        }
        //        index2++;
        //    }
        //    index1++;
        //    index2 = 0;
        //}
        #endregion

    }
}