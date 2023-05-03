using System;
using System.Collections.Generic;
using System.IO;
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
            Console.WriteLine("Search Value in Array : " + SearchIndex(nums,target).ToString() + "\r\n");

            string sn = "82734";
            Console.WriteLine("Decimal number is called deci-binary if each of its digits is either 0 or 1 without any leading zeros : " + MinPartitions(sn) + "\r\n");

            int[][] boxTypes = new int[][] { 
                    new int[] { 1, 2, 3 },
                    new int[] { 3, 2, 1 },
                };
            int targetsize = 4;
            Console.WriteLine(" Maximum Units on a Truck : " + MaximumUnits(boxTypes, targetsize) + "\r\n");

            int[] sortArray = new int[] { 3, 4, 7, -1, 9, 0, 2, 1 };
            Console.WriteLine("Array Sort : " + string.Join(" , ", arraySortInteger(sortArray)) + "\r\n");

            int ValBinary = 1041;
            Console.WriteLine("Binary Gap: " + BinaryGap(ValBinary) + "\r\n");

            int[] arrNumbs = new int[] { 3, 8, 9, 7, 6 };
            int K = 3;
            Console.WriteLine("CyclicRotation : " + string.Join(" , ",CyclicRotation(arrNumbs,K)) + "\r\n");

            int[] numsArray = new int[] { 9,3,9,3,9,7,9};
            Console.WriteLine("Find value that occurs in odd number of elements. : " + OddOccurrencesInArray(numsArray) + "\r\n");

            int X = 10, Y = 85, D = 30;
            Console.WriteLine("FrogJmp - Count minimal number of jumps from position X to Y. : " + solutionFrogJmp(X,Y,D) + "\r\n");

            int[] missingElement = new int[] { 2, 3, 1, 5 };
            Console.WriteLine(" PermMissingElem - Find the missing element in a given permutation. : " + PermMissingElemSolution(missingElement) + "\r\n");

            int[] numArrayTape = new int[] { 3,1,2,4,3 };
            Console.WriteLine(" TapeEquilibrium - Minimize the value |(A[0] + ... + A[P-1]) - (A[P] + ... + A[N-1])|. : " + TapeEquilibriumSolutions(numsArray) + "\r\n");

            //Container With Most Water - You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
            int[] heights = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Console.WriteLine(" Container With Most Water - You are given an integer array height of length n  : " + ContainerWithMostWater(heights) + "\r\n");

            //20. Valid Parentheses
            s = "(]";
            Console.WriteLine(" 20. Valid Parentheses  : " + IsValid(s) + "\r\n");

            //2390. Removing Stars From a String
            string strValue = "leet**cod*e";
            Console.WriteLine(" 2390. Removing Stars From a String : " + RemoveStars(strValue) + "\r\n");

            //71.Simplify Path
            string path = "/../";
            Console.WriteLine(" 71. Simplify Path =" + SimplifyPath(path) + "\r\n");

            //946. Validate Stack Sequences
            int[] pushed = new int[] { 1, 2, 3, 4, 5 };
            int[] popped = new int[] { 4, 5, 3, 2, 1 };
            Console.WriteLine(" 946. Validate Stack Sequences : " + ValidateStackSequences(pushed,popped) + "\r\n");

            //258. Add Digits
            int num = 38;
            Console.WriteLine(" 258. Add Digits numbers : " + AddDigits(num) + "\r\n");

            //1491. Average Salary Excluding the Minimum and Maximum Salary
            int[] salary = new int[] { 4000, 3000, 1000, 2000 };
            Console.WriteLine(" 1491. Average Salary Excluding the Minimum and Maximum Salary : " + Average(salary) + "\r\n");

            //1822. Sign of the Product of an Array
            int[] numsArry = new int[] { -1, -2, -3, -4, 3, 2, 1 };
            Console.WriteLine("1822. Sign of the Product of an Array : " + ArraySign(numsArry) + "\r\n");

            //2215. Find the Difference of Two Arrays
            int[] nums1 = new int[] { 1, 2, 3 };
            int[] nums2 = new int[] { 2, 4, 6 };
            foreach( var Obj in FindDifference(nums1, nums2).SelectMany(lValue=> lValue.Select(obj => obj)))
            {
                Console.WriteLine("2215. Find the Difference of Two Arrays :  " + Obj);
            }

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

        static int OddOccurrencesInArray(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int resultXor = nums[0];
            for(int iCount=1;iCount<nums.Length;iCount++)
            {
                resultXor ^= nums[iCount];
            }

            return resultXor;
        }

        static int solutionFrogJmp(int X,int Y,int D)
        {
            int iCount = 0;

            while(X<Y)
            {
                X += D;
                iCount++;
            }
            return iCount;
        }

        static int PermMissingElemSolution(int[] A)
        {
            if (A.Length == 0)
                return 0;

            int missingElement = A[0] ^ 1;

            for (int icount=1;icount<A.Length;icount++)
            {
                missingElement ^=  A[icount] ^ (icount + 1);
            }

            return missingElement ^ (A.Length + 1);
        }

        static int TapeEquilibriumSolutions(int[] numsArray)
        {
            if (numsArray.Length == 0)
                return 0;

            int totalSum = 0, sumTillCurrentIndex = numsArray[0];
            for (int iCount = 0; iCount < numsArray.Length; iCount++)
            {
                totalSum += numsArray[iCount];
            }

            var minDifference = Math.Abs(numsArray[0] - (totalSum - numsArray[0]));
            totalSum -= numsArray[0];


            for (int jCount = 2; jCount <= numsArray.Length; jCount++)
            {
                sumTillCurrentIndex += numsArray[jCount - 1];
                totalSum -= numsArray[jCount - 1];

                if (minDifference > Math.Abs(totalSum - sumTillCurrentIndex))
                {
                    minDifference = Math.Abs(totalSum - sumTillCurrentIndex);
                }
            }

            return minDifference;
        }

        static int ContainerWithMostWater(int[] height)
        {
            //Container With Most Water
            if (height.Length == 0)
                return 0;

            //Declaration Left & Right
            int maxResult = 0, left = 0, right = height.Length - 1;

            // Array Left and Right
            while(left < right)
            {
                if(height[left] < height[right])
                {
                    //Find out the index
                    var arrayIndex = Math.Min(height[right],height[left])*(right-left);
                    maxResult = Math.Max(maxResult, arrayIndex);
                    left++;
                }
                else
                {
                    //Find out the index
                    var arrayIndex = Math.Min(height[right], height[left]) * (right - left);
                    maxResult = Math.Max(maxResult, arrayIndex);
                    right--;
                }
            }
            return maxResult;
        }
        static bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            Stack<char> stValue = new Stack<char>();

            foreach(var items in s.ToCharArray())
            {
                if (items == '(')
                    stValue.Push(')');
                else if (items == '{')
                    stValue.Push('}');
                else if (items == '[')
                    stValue.Push(']');
                else if (stValue.Count == 0 || stValue.Pop() != items)
                    return false;
              
            }
            return stValue.Count == 0;
        }

        static string RemoveStars(string s)
        {
            //Check input string is null/empty
            if (string.IsNullOrEmpty(s))
                return new ArgumentException(string.Format("{0} is not valid string", s)).ToString();

            //Declaration
            Stack<char> stValue = new Stack<char>();

            //Iterate the input string 
            foreach (char item in s.ToCharArray())
            {
                if (!s.Any())
                {
                    stValue.Push(item);
                }
                else
                {
                    if (item == '*')
                        stValue.Pop();
                    else
                        stValue.Push(item);
                }
            }
            //Convert to stack to array and print the array value.
            char[] charArrayValue = stValue.ToArray();
            Array.Reverse(charArrayValue);
            return new string(charArrayValue);
        }

        static string SimplifyPath(string path)
        {
            //First check is null or empty.
            if (string.IsNullOrEmpty(path))
                return new ArgumentException(string.Format("{0} is not null or empty.")).ToString();

            //Declaration of the variable 
            var slash = "/";
            var dirs = path.Split(slash);
            var dirList = new List<string>();

            //Loop the check the value is present or not.
            foreach(var dir in dirs)
            {
                if(dir.Equals(".."))
                {
                    if(dirList.Count >0)
                        dirList.RemoveAt(dirList.Count - 1);
                }
                else if(!string.IsNullOrEmpty(dir))
                {
                    if (!dir.Equals("."))
                        dirList.Add(dir);
                }
            }

            //List and slash values
            return slash + string.Join(slash, dirList);
        }

        static bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            //Check the array are equal
            if (pushed.Length != popped.Length)
                return false;

            //Declare the stack value.
            Stack<int> number_stack = new Stack<int>();
            int jCount = 0;

            foreach(int iCount in pushed)
            {
                number_stack.Push(iCount);
                while(number_stack.Count > 0 && jCount < popped.Length && number_stack.Peek() == popped[jCount])
                {
                    number_stack.Pop();
                    jCount++;
                }
            }

            return jCount == popped.Length;
        }

        static int AddDigits(int num)
        {
            //First check is null/empty
            if (string.IsNullOrEmpty(num.ToString()))
                return 0;

            while(num/10!=0)
            {
                // Assign the values
                int fullnumber = num;
                num = 0;
                while(fullnumber>0)
                {
                    num += fullnumber % 10;
                    fullnumber /= 10;
                }
            }

            return num;
        }
        static int BulbSwitch(int n)
        {
                if (string.IsNullOrEmpty(n.ToString()))
                    return n;

                return (int)Math.Sqrt(n);
        }

        static double Average(int[] salary)
        {
            //Check if input array was null/empty
            if (salary == null)
                return Convert.ToDouble(0);

            //Declare local variables
            double results = 0.0;

            //First check less than are equal to 2 
            if (salary.Length <= 2)
                return results;

            //Sort the array
            Array.Sort(salary);

            //Check the input array length has equal to 3
            if (salary.Length == 3)
                return salary[1];

            //Loop through the count of the value 
            for (int iCount = 1; iCount < salary.Length - 1; iCount++)
                results += salary[iCount];

            return (results / (salary.Length - 2));
        }

        //1822. Sign of the Product of an Array
        static int ArraySign(int[] nums)
        {
            //Check if null
            if (nums == null)
                return 0;

            int result = 1;

            //Looping the value in numbers
           foreach(var num in nums)
            {
                if (num == 0)
                {
                    return 0;
                }
                else if (num < 0)
                {
                    result *= -1;
                }
                else
                {
                    result *= 1;
                }
            }

            return result;
        }

        //2215. Find the Difference of Two Arrays
        static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            //Find the difference of the array
            IList<IList<int>> result = new List<IList<int>>();

            //Hashset Declaration
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            //First Loop to check 
            for (int iCount = 0; iCount < nums1.Length; iCount++)
                if (!nums2.Contains(nums1[iCount]))
                    set1.Add(nums1[iCount]);

            //Second Loop to check 
            for (int jCount = 0; jCount < nums2.Length; jCount++)
                if (!nums1.Contains(nums2[jCount]))
                    set2.Add(nums2[jCount]);

            //Add to the List 
            result.Add(set1.ToList());
            result.Add(set2.ToList());

            //Return the results
            return result;

        }

    }
}
