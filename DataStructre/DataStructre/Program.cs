using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructre
{
    class Program
    {
        static void Main(string[] args)
        {
            //Remove Duplicte in  String 
            Console.WriteLine("Remove the Duplicate Value : " + RemoveDuplicateCharsInString("Remove Duplicate Value") + "\n");

            //Reverse String
            Console.WriteLine("Reverse the String  : " + StringRevere("Remove Duplicate Value") + "\n");

            //SubString in string.
            FindallSubString("SubstringToFind");

            //TwoSumOptimized
            int[] resultOfOptimized = TwoSumOptimized(new int[] { 1, 1, 2, 1, 1, 2 }, 4);
            Console.WriteLine("------------------ Optimized Solution ------------------");
            Console.WriteLine("--------- Time Complexity: O(n), Space complexity: O(n)   ---------");
            Console.WriteLine(string.Join(" ", resultOfOptimized));

            //Running Sum of 1d Array
            int[] ArrayNums = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("Running Sum of 1d Array : " + string.Join(" , ", RunningSum(ArrayNums)) + "\n");

            string s = "egg", t = "add";
            Console.WriteLine("Isomorphic Strings: " + (IsIsomorphic(s, t) ? "True" : "False") );

            int[] nums = new int[] { -2,3,4,7,8,9,11,13 };
            int target = 11;
            Console.WriteLine("Search Value in Array : " + SearchIndex(nums,target).ToString());

            string sn = "82734";
            Console.WriteLine("Decimal number is called deci-binary if each of its digits is either 0 or 1 without any leading zeros : " + MinPartitions(sn));

            int[][] boxTypes = new int[][] { 
                    new int[] { 1, 2, 3 },
                    new int[] { 3, 2, 1 },
                };
            int targetsize = 4;
            Console.WriteLine(" Maximum Units on a Truck : " + MaximumUnits(boxTypes, targetsize));

            int[] sortArray = new int[] { 3, 4, 7, -1, 9, 0, 2, 1 };
            Console.WriteLine("Array Sort : " + string.Join(" , ", arraySortInteger(sortArray)));

            int ValBinary = 1041;
            Console.WriteLine("Binary Gap: " + BinaryGap(ValBinary));

            int[] arrNumbs = new int[] { 3, 8, 9, 7, 6 };
            int K = 3;
            Console.WriteLine("CyclicRotation : " + string.Join(" , ",CyclicRotation(arrNumbs,K)));

            Console.ReadLine();
        }
        static string RemoveDuplicateCharsInString(string inputStrValue)
        {
            // Store encountered letters in this string.
            string tble = string.Empty;

            // Store the result in this string.
            string reValue = string.Empty;

            // Loop over each character.
            foreach (char chrValue in inputStrValue)
            {
                // See if character is in the table.
                if (tble.IndexOf(chrValue) == -1)
                {
                    // Append to the table and the result.
                    tble += chrValue;
                    reValue += chrValue;
                }
            }
            return reValue;
        }

        static string StringRevere(string InputStrValue)
        {
            // Store the result in this string.
            string returnString = string.Empty;

            for (int i = InputStrValue.Length - 1; i >= 0; i--)
                returnString += InputStrValue[i];

            return returnString;
        }

        static void FindallSubString(string InputStrValue)
        {
            // Store the result in this string.
            string returnString = string.Empty;

            Console.WriteLine("SubString.");

            // Avoid full length.
            for (int length = 1; length < InputStrValue.Length; length++)
            {
                // End index is tricky.
                for (int start = 0; start <= InputStrValue.Length - length; start++)
                {
                    string substring = InputStrValue.Substring(start, length);
                    Console.WriteLine(substring);
                }
            }

        }

        //Integer array of Indices
        static int[] TwoSumOptimized(int[] nums, int target)
        {
            //Declarations
            int arrayLength = nums.Length;
            Dictionary<int, int> resultDictionary = new();

            //Validations
            if (nums == null || arrayLength < 2)
            {
                return Array.Empty<int>();
            }

            //Logic
            for (int i = 0; i < arrayLength; i++)
            {
                int firstNumber = nums[i];
                int secondNumber = target - firstNumber;
                if (resultDictionary.TryGetValue(secondNumber, out int index))
                {
                    return new[] { index, i };
                }
                resultDictionary[firstNumber] = i;
            }
            return Array.Empty<int>(); ;
        }

        static int[] RunningSum(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;

            for (int iCount = 1; iCount < nums.Length; iCount++)
            {
                nums[iCount] += nums[iCount - 1];
            }
            return nums;
        }

        static int PivotIndex(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 1;

            int totalSum = nums.Sum();
            int leftsum = 0;

            for (int iCount = 0; iCount < nums.Length; iCount++)
            {
                if ((totalSum = (totalSum - nums[iCount])) == leftsum)
                {
                    return iCount;
                }
                else
                {
                    leftsum += nums[iCount];
                }

            }
            return -1;
        }

        static bool IsIsomorphic(string s, string t)
        {
            if (s == null || t == null || s.Length != t.Length)
                return false;

            var dictIsomorphic = new Dictionary<char, char>();

            for (int iCount = 0; iCount < s.Length; iCount++)
            {
                if (!dictIsomorphic.ContainsKey(s[iCount]) && !dictIsomorphic.ContainsValue(t[iCount]))
                {
                    dictIsomorphic[s[iCount]] = t[iCount];
                }
                else if (!dictIsomorphic.ContainsKey(s[iCount]) || dictIsomorphic[s[iCount]] != t[iCount])
                {
                    return false;
                }
            }
            return true;

        }

        static int SearchIndex(int[] nums,int target)
        {

            if (nums == null || nums.Length == 0)
                return 0;

            //Declartion
            int middle = 0, left = 0,right;

            Array.Sort(nums);
            
            right = nums.Length - 1;

            while(left<=right)
            {
                middle = (left + right) / 2;
                if (nums[middle] == target)
                    return middle;
                else if (target < nums[middle])
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            return 0;

        }

        static int MinPartitions(string n)
        {
            if (n == null || n.Length == 0)
                return -1;

            int numberResult = 0;

            for (int iCount = 0; iCount < n.Length; iCount++)
            {
                numberResult = Math.Max(numberResult, n[iCount] - '0');
                if (numberResult == 9) return numberResult;
            }

            return numberResult;
        }

        static int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            //Null check 
            if (boxTypes == null || boxTypes.Length == 0)
                return -1;

            //Declartion
            int size = 0, units = 0;

            //Loop the array
            foreach (var boxType in boxTypes.OrderByDescending(bt => bt[1]))
            {
                if (size + boxType[0] < truckSize)
                {
                    units += boxType[0] * boxType[1];
                    size += boxType[0];
                }
                else
                {
                    units += (truckSize - size) * boxType[1];
                    break;
                }

            }
            return units;
        }

        static int[] arraySortInteger(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return nums;

            int temp = 0;

            for (int icount = 0; icount <= nums.Length - 1; icount++)
            {
                for (int jcount = icount + 1; jcount < nums.Length; jcount++)
                {
                    if (nums[icount] > nums[jcount])
                    {
                        temp = nums[icount];
                        nums[icount] = nums[jcount];
                        nums[jcount] = temp;
                    }
                }
            }
            return nums;
        }
        
        static int BinaryGap(int N)
        {
            if (N == 0)
                return N;

            //Declaration
            int count = 0, maxCount = 0;
            var nums = Convert.ToString(N,2);

            for(int iCount=0;iCount<nums.Length;iCount++)
            {
                if(nums[iCount]=='0')
                {
                    count++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, count);
                    count = 0;
                }
            }
            return maxCount;
        }

        static int[] CyclicRotation(int[] A,int k)
        {
            if (A == null || A.Length == 0)
                return A;
          
            for(int jCount=0; jCount < k; jCount++)
            {
                var current = A[0];
                var next = A[1];
                for (int iCount = 0; iCount < A.Length - 1; iCount++)
                {
                    next = A[iCount + 1];
                    A[iCount + 1] = current;
                    current = next;
                }

                A[0] = next;
            }

            return A;
        }
    }
}
