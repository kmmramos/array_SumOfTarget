namespace Array_SumOfTarget
{
    class Program
    {
        static void Main(String[] args)
        {
            try
            {
                Console.Write("Please enter the size of your array: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] nums = new int[size];
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write("Please enter your number: ");
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Please write type your target value: ");
                int target = Convert.ToInt32(Console.ReadLine());

                int[] answer = new int[2];
                answer = TwoSum(nums, target);
                Console.WriteLine("Here are the numbers that produces {0} when added: ", target);
                foreach (var item in answer)
                {
                    Console.WriteLine(nums[item] + " in index " + item);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //OPTIMIZED SOLUTION
        public static int[] TwoSum(int[] nums, int target)
        {
            int arrayLength = nums.Length;
            Dictionary<int, int> resultDictionary = new();
            if (nums == null || arrayLength < 2)
            {
                return Array.Empty<int>();
            }
            for (int i = 0; i < arrayLength; i++)
            {
                int firstNumber = nums[i];
                int secondNumber = target - firstNumber;
                if (resultDictionary.TryGetValue(secondNumber, out int index))
                {
                    return new[] {
                    index,
                    i
                };
                }
                resultDictionary[firstNumber] = i;
            }
            return Array.Empty<int>(); ;
        }

        //NORMAL SOLUTION
        //     public int[] TwoSum(int[] nums, int target) 
        //     {
        //         int numsLength = nums.Length;
        //         if (numsLength <= 1)
        //         {
        //             return null;
        //         }
        //         for (int P1 = 0; P1 < nums.Length; P1++) 
        //         {
        //             int noToFind = target - nums[P1];
        //             for (int P2 = P1 + 1; P2 < nums.Length; P2++) 
        //             {
        //                 if (noToFind == nums[P2])
        //                 {
        //                     return new int[] {P1, P2};
        //                 }
        //             }
        //         }
        //         return null;
        //     }  
    }
}