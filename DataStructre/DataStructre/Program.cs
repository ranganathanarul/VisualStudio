﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using static System.Net.WebRequestMethods;

namespace DataStructre
{
    class Program
    {
        [STAThread]
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
            Console.WriteLine("Isomorphic Strings: " + (IsIsomorphic(s, t) ? "True" : "False"));

            int[] nums = new int[] { -2, 3, 4, 7, 8, 9, 11, 13 };
            int target = 11;
            Console.WriteLine("Search Value in Array : " + SearchIndex(nums, target).ToString() + "\r\n");

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
            Console.WriteLine("CyclicRotation : " + string.Join(" , ", CyclicRotation(arrNumbs, K)) + "\r\n");

            int[] numsArray = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            Console.WriteLine("Find value that occurs in odd number of elements. : " + OddOccurrencesInArray(numsArray) + "\r\n");

            int X = 10, Y = 85, D = 30;
            Console.WriteLine("FrogJmp - Count minimal number of jumps from position X to Y. : " + solutionFrogJmp(X, Y, D) + "\r\n");

            int[] missingElement = new int[] { 2, 3, 1, 5 };
            Console.WriteLine(" PermMissingElem - Find the missing element in a given permutation. : " + PermMissingElemSolution(missingElement) + "\r\n");

            int[] numArrayTape = new int[] { 3, 1, 2, 4, 3 };
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
            Console.WriteLine(" 946. Validate Stack Sequences : " + ValidateStackSequences(pushed, popped) + "\r\n");

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
            foreach (var Obj in FindDifference(nums1, nums2).SelectMany(lValue => lValue.Select(obj => obj)))
            {
                Console.WriteLine("2215. Find the Difference of Two Arrays :  " + Obj);
            }

            //649. Dota2 Senate
            string senate = "RD";
            Console.WriteLine("\r\n" + "649. Dota2 Senate : " + PredictPartyVictory(senate));

            //1456. Maximum Number of Vowels in a Substring of Given Length
            string sValues = "abciiidef"; int k = 3;
            Console.WriteLine("\r\n" + "1456. Maximum Number of Vowels in a Substring of Given Length : " + MaxVowels(sValues, k));

            int[][] mat = new int[][]
            {
                new int[]{1,2,3},
                new int[]{4,5,6},
                new int[]{7,8,9},
            };

            Console.WriteLine("\r\n" + "1572. Matrix Diagonal Sum : " + DiagonalSum(mat));

            int rowIndex = 0;
            Console.WriteLine("\r\n" + "119. Pascal's Triangle II : [" + String.Join(",", GetRow(rowIndex)) + "]");


            string sValue = "ab#c", tValue = "ad#c";
            Console.WriteLine("\r\n" + "844. Backspace String Compare  : " + BackspaceCompare(sValue, tValue) + "\r\n");

            string strValue1 = "anagram", strValue2 = "nagaram";
            Console.WriteLine("242. Valid Anagram : " + IsAnagram(strValue1, strValue2) + "\r\n");

            int[] numsValues = new int[] { 1, 2, 3, 1 };
            Console.WriteLine("217. Contains Duplicate : " + ContainsDuplicate(numsValues) + "\r\n");

            int[] numsValues1 = new int[] { 1, 2, 1 };
            Console.WriteLine("1929. Concatenation of Array : " + GetConcatenation(numsValues1) + "\r\n");

            string strvalue = "abc";
            Console.WriteLine("3174. Clear Digits : " + ClearDigits(strvalue) + "\r\n");

            string svalues1 = "daabcbaabcbc", svalue2 = "abc";
            Console.WriteLine("1910. Remove All Occurrences of a Substring : " + RemoveOccurrences(svalues1, svalue2) + "\r\n");

            int nthValue = 10;
            Console.WriteLine("2698. Find the Punishment Number of an Integer : " + PunishmentNumber(nthValue) + "\r\n");

            uint nthValue1 = 0000001010010100;
            Console.WriteLine("190. Reverse Bits : " + reverseBits(nthValue1) + "\r\n");

            //int[] numsValue2 = new int[] { 1, 3 };
            //Console.WriteLine("1863. Sum of All Subset XOR Totals" + SubsetXORSum(numsValue2) + "\r\n");

            string strWord = "aabcaba";
            int kthValue1 = 0;
            Console.WriteLine(" 3085. Minimum Deletions to Make String K-Special " + MinimumDeletions(strWord, kthValue1) + "\r\n");

            string sthvalue = "abcdefghi";
            char fill = 'x';
            int kthvalue = 3;
            Console.WriteLine("2138. Divide a String Into Groups of Size k : ['" + string.Join(", ", DivideString(sthvalue, kthvalue, fill)) + "']\r\n");

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

        static int SearchIndex(int[] nums, int target)
        {

            if (nums == null || nums.Length == 0)
                return 0;

            //Declartion
            int middle = 0, left = 0, right;

            Array.Sort(nums);

            right = nums.Length - 1;

            while (left <= right)
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
            var nums = Convert.ToString(N, 2);

            for (int iCount = 0; iCount < nums.Length; iCount++)
            {
                if (nums[iCount] == '0')
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

        static int[] CyclicRotation(int[] A, int k)
        {
            if (A == null || A.Length == 0)
                return A;

            for (int jCount = 0; jCount < k; jCount++)
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
            for (int iCount = 1; iCount < nums.Length; iCount++)
            {
                resultXor ^= nums[iCount];
            }

            return resultXor;
        }

        static int solutionFrogJmp(int X, int Y, int D)
        {
            int iCount = 0;

            while (X < Y)
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

            for (int icount = 1; icount < A.Length; icount++)
            {
                missingElement ^= A[icount] ^ (icount + 1);
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
            while (left < right)
            {
                if (height[left] < height[right])
                {
                    //Find out the index
                    var arrayIndex = Math.Min(height[right], height[left]) * (right - left);
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

            foreach (var items in s.ToCharArray())
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
            foreach (var dir in dirs)
            {
                if (dir.Equals(".."))
                {
                    if (dirList.Count > 0)
                        dirList.RemoveAt(dirList.Count - 1);
                }
                else if (!string.IsNullOrEmpty(dir))
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

            foreach (int iCount in pushed)
            {
                number_stack.Push(iCount);
                while (number_stack.Count > 0 && jCount < popped.Length && number_stack.Peek() == popped[jCount])
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

            while (num / 10 != 0)
            {
                // Assign the values
                int fullnumber = num;
                num = 0;
                while (fullnumber > 0)
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
            foreach (var num in nums)
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

        //649. Dota2 Senate
        static string PredictPartyVictory(string senate)
        {
            if (senate == null)
                return null;

            List<char> current = new List<char>(senate);

            for (int d = 0, r = 0; ;)
            {
                if (current.All(cValue => cValue == 'R'))
                    return "Radiant";
                if (current.All(cValue => cValue == 'C'))
                    return "Dire";

                List<char> list = new();

                for (int iCount = 0; iCount < senate.Length; iCount++)
                {
                    char man = current[iCount];

                    if (man == 'R')
                        if (d > 0)
                            d -= 1;
                        else
                        {
                            r += 1;
                            list.Add('R');
                        }
                    else if (r > 0)
                        r -= 1;
                    else
                    {
                        d += 1;
                        list.Add('D');
                    }
                }
                current.Clear();

                for (int jCount = 0; jCount < list.Count; ++jCount)
                {
                    if (list[jCount] == 'D')
                        if (r > 0)
                            r -= 1;
                        else
                            current.Add('D');
                    else if (d > 0)
                        d -= 1;
                    else
                        current.Add('R');
                }

            }
        }

        //1456. Maximum Number of Vowels in a Substring of Given Length
        static int MaxVowels(string s, int k)
        {
            //Check the value is null or empty
            if (string.IsNullOrEmpty(s))
                return 0;

            //Declare the values 
            int ansValue = 0, cuntValue = 0;

            //Loop the values
            for (int iCount = 0, jCount = 0; iCount < s.Length; iCount++)
            {
                if (IsVowel(s[iCount]))
                    cuntValue++;

                if (iCount - jCount + 1 == k)
                {
                    ansValue = Math.Max(ansValue, cuntValue);
                    if (IsVowel(s[jCount++]))
                    {
                        cuntValue--;
                    }
                }
            }
            return ansValue;
        }

        public static bool IsVowel(char chr)
        {
            return chr == 'a' || chr == 'e' || chr == 'i' || chr == 'o' || chr == 'u';
        }

        //1572. Matrix Diagonal Sum
        static int DiagonalSum(int[][] mat)
        {
            // Input Value check 
            if (mat == null || mat.Length == 0)
                return 0;

            //Decalaration
            int nCount = mat.Length;
            int resultsValue = 0;

            //Loop to check the value
            for (int iCount = 0; iCount < mat.Length; iCount++)
                resultsValue += mat[iCount][iCount] + mat[iCount][mat.Length - 1 - iCount];

            return mat.Length % 2 == 1 ? resultsValue - mat[mat.Length / 2][mat.Length / 2] : resultsValue;
        }

        //119. Pascal's Triangle II
        static IList<int> GetRow(int rowIndex)
        {
            if (rowIndex < 0)
                return null;
            //Declare the return Value
            IList<int> rows = new List<int>();

            for (int iCount = 0; iCount <= rowIndex; iCount++)
            {
                rows.Add(1);

                for (int jCount = iCount - 1; jCount > 0; jCount--)
                {
                    rows[jCount] += rows[jCount - 1];
                }

            }

            return rows;
        }

        //844. Backspace String Compare

        static bool BackspaceCompare(string s, string t)
        {

            return RemoveString(s) == RemoveString(t);
        }


        static string RemoveString(string str)
        {
            StringBuilder strBuilder = new StringBuilder();

            foreach (char c in str)
            {
                if (c != '#')
                {
                    strBuilder.Append(c);

                }
                else if (strBuilder.Length > 0)
                {
                    strBuilder.Remove(strBuilder.Length - 1, 1);
                }
            }
            return strBuilder.ToString();
        }

        static bool IsAnagram(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
                return false;

            s = string.Concat(s.OrderBy(x => x));
            t = string.Concat(t.OrderBy(x => x));

            return s == t;

        }

        //217. Contains Duplicate
        static bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length == 0 || nums == null)
                return false;

            var hSet = new HashSet<int>(nums);

            if (hSet.Count != nums.Length)
                return true;
            else
                return false;


        }

        //1929. Concatenation of Array
        static int[] GetConcatenation(int[] nums)
        {
            //Check null or empty
            if (nums.Length == 0 || nums == null)
                return null;

            //Create the returnvalue array
            int[] answerValue = new int[nums.Length * 2];

            for (int iCount = 0; iCount < nums.Length; iCount++)
            {
                answerValue[iCount] = nums[iCount];
                answerValue[iCount + 1] = nums[iCount];
            }

            return answerValue;
        }

        //3174. Clear Digits

        static string ClearDigits(string s)
        {
            //Check is null/empty
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            //Declaration
            StringBuilder strBuilder = new StringBuilder(s);

            //Loop through the value
            for (int icount = 1; icount < strBuilder.Length;)
            {
                //check the condition
                if (char.IsDigit(strBuilder[icount]))
                {
                    strBuilder.Remove(icount, 1);
                    strBuilder.Remove(icount - 1, 1);
                    icount--;
                }
                else
                    icount++;
            }

            //Return the results
            return strBuilder.ToString();
        }



        //1910. Remove All Occurrences of a Substring
        static string RemoveOccurrences(string s, string part)
        {
            // check the i/p string is null/empty.
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(part))
                return part;

            //stringBuilder for efficient string manipulation
            StringBuilder strBuilder = new StringBuilder(s);

            int index = strBuilder.ToString().IndexOf(part);

            while (index != -1)
            {
                //Remove leftmost occurrence of the substring 'part'
                strBuilder.Remove(index, part.Length);

                //Find the next occurrence of 'part'
                index = strBuilder.ToString().IndexOf(part);
            }
            return strBuilder.ToString();
        }


        //2698. Find the Punishment Number of an Integer

        static int PunishmentNumber(int n)
        {
            //Check the input values 
            if (n == null || n == 0)
                return 0;

            int outResult = 1;
            for (int iCount = 9; iCount <= n; iCount++)
            {
                //Decalaration
                int pNumber = iCount * iCount;

                //Check the value number can be abe to split it.
                if (CanSplitToNumbers(pNumber, iCount))
                {
                    outResult += pNumber;
                }
            }

            return outResult;

            static bool CanSplitToNumbers(int pNumber, int iCount)
            {
                //Check the punishment number and output number.
                if (pNumber == iCount)
                    return true;

                for (int decValue = 10; decValue < pNumber; decValue *= 10)
                {
                    //Calculates the quotient of two numbers and also returns the remainder in an output parameter.
                    int outpValueq = Math.DivRem(pNumber, decValue, out int rempResult);

                    if (outpValueq <= iCount && CanSplitToNumbers(rempResult, iCount - outpValueq))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        //190. Reverse Bits
        static uint reverseBits(uint n)
        {
            // check the input is valid
            if (n == null || n == 0)
                return 0;
            //Declaration
            uint outResults = 0;

            for (int iCount = 0; iCount < 32; iCount++)
            {
                outResults = (outResults << 1) | (n & 1);
                n >>= 1;
            }

            return outResults;
        }

        //1863. Sum of All Subset XOR Totals
        int SubsetXORSum(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int results = 0;
            traverse(nums, 0, 0, ref results);
            return results;

        }
        void traverse(int[] nums, int index, int currentXOR, ref int results)
        {
            if (index == nums.Length)
            {
                results += currentXOR;
                return;
            }
            traverse(nums, index + 1, currentXOR ^ nums[index], ref results);
            traverse(nums, index + 1, currentXOR, ref results);
        }

        static int MinimumDeletions(string word, int k)
        {
            Span<int> cValues = stackalloc int[26];//*Initialize frequency span.
            int length = word.Length,
            min = Int32.MaxValue;

            for (int iCount = 0; iCount < length; iCount++) //*Add every char to frequency span.
                cValues[word[iCount] - 97]++;

            for (int iCounts = 0; iCounts < 26; iCounts++)
            {
                int cur = cValues[iCounts];
                if (cur == 0) continue; //* Skip empty frequencies.

                int dlValue = 0;

                for (int jCount = 0; jCount < 26; jCount++)
                {
                    int tValue = cValues[jCount];
                    if (tValue == 0) continue; //* Skip empty frequencies.

                    /* if "Temp" is bigger than "Current" add "Temp"
                    * else if distance between "Current" and "Temp" is bigger than "k" add "Temp" - "Current" - "k"
                    * else add 0 */
                    dlValue += cur > tValue ? tValue : tValue - cur - k > 0 ? tValue - cur - k : 0;
                }

                if (dlValue < min) min = dlValue; //* Update the result value.
            }

            return min;
        }

        //2138. Divide a String Into Groups of Size k
        static string[] DivideString(string s, int k, char fill)
        {
            
            int groups = (s.Length + k - 1) / k; // Ceiling division to get total groups
            String[] result = new String[groups];

            int index = 0;
            for (int iCount = 0; iCount < groups; iCount++)
            {
                StringBuilder sb = new StringBuilder();

                for (int jCount = 0; jCount < k; jCount++)
                {
                    if (index < s.Length)
                    {
                        sb.Append(s[index++]);
                    }
                    else
                    {
                        sb.Append(fill);
                    }
                }

                result[iCount] = sb.ToString();
            }

            return result;
        }
    }
}