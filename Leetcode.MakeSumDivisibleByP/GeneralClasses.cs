namespace Leetcode.MakeSumDivisibleByP
{
    public class GeneralClasses
    {
        public static int GetMaxInArray(int[] array)
        {
            int maxNumber = array[0];

            for (int i = 1; i < array.Length; i++) {
                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }
            }

            return maxNumber;

            //return array.ToList().OrderByDescending(x => x).First();
        }

        public static int[] ReverseAnArray(int[] array)
        {
            List<int> reversedArr = new List<int>();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArr.Add(array[i]);
            }

            return reversedArr.ToArray();
        }

        public static int Get2ndLargestNumber(int[] array)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            for (int i = 0; i < array.Length; i++) {
                if (array[i] > largest)
                {
                    secondLargest = largest;
                    largest = array[i];
                }
                else if (array[i] > secondLargest && array[i] != largest)
                {
                    secondLargest = array[i];
                }
            }

            return secondLargest;

            //return array.ToList().Distinct().OrderByDescending(x => x).Skip(1).First();
        }

        public static int[] RemoveDuplicateArray(int[] array)
        {
            HashSet<int> seen = [.. array];

            //foreach (int num in array)
            //{
            //    seen.Add(num);  // HashSet automatically ignores duplicates
            //}

            return new List<int>(seen).ToArray();

            //return array.ToList().OrderBy(x => x).Distinct().ToArray();
        }

        public static bool IsPalindromeString(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                    return false;

                left++;
                right--;
            }

            return true;

            //string reversedString = new string(str.Reverse().ToArray());
            //return str == reversedString;
        }

        public static int[] MergeSortedArrays(int[] a, int[] b)
        {
            int i = 0, j = 0, k = 0;
            int[] result = new int[a.Length + b.Length];

            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                    result[k++] = a[i++];
                else
                    result[k++] = b[j++];
            }

            // Copy any leftovers
            while (i < a.Length)
                result[k++] = a[i++];

            while (j < b.Length)
                result[k++] = b[j++];

            return result;

            //return arr1.Concat(arr2).OrderBy(x => x).ToArray();
        }

        public static bool NumberInArray(int number, int[] array) //linear search
        {
            for (int i = 0; i < number; i++)
            {
                if (array[i] == number) {  return true; }
            }

            return false;
        }

        public static bool BinarySearch(int[] arr, int target) // Binary search - array must be sorted
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                    return true;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return false; // Target not found
        }

        public static bool BinarySearchRecursive(int[] array, int target, int left, int right)
        {
            if (left > right)
                return false;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid] == target)
                    return true;
                else if (array[mid] < target)
                    return BinarySearchRecursive(array, target, mid + 1, right);
                else
                    return BinarySearchRecursive(array, target, left, mid - 1);
            }

            return false; // Target not found
        }

        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap elements
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                // Find the index of the smallest element in the remaining array
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum with the first element of the unsorted part
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements greater than key to one position ahead
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                // Insert key into its correct position
                arr[j + 1] = key;
            }
        }

        public static int[] ProductArray(int[] array)
        {
            int n = array.Length;
            int[] result = new int[n];

            for(int i = 0; i < n; i++)
            {
                int product = 1;
                for(int j = 0; j < n; j++)
                {
                    if(i != j)
                    {
                        product *= array[j];
                    }
                }

                result[i] = product;
            }

            return result;
        }

        public static int[] RotateLeft(int d, List<int> arr)
        {
            List<int> result = new List<int>();

            for (int i = d; i < arr.Count; i++)
            {
                result.Add(arr[i]);
            }

            for (int i = 0; i < d; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++) { 
                var remain = target - nums[i];
                for(int j = 1; j < nums.Length; j++)
                {
                    if(remain == nums[j])
                    {
                        return [i, j];
                    }
                }
            }

            return [];
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "")
                        return "";
                }

            return prefix;
        }

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int write = 1;

            for (int read = 1; read < nums.Length; read++)
            {
                if (nums[read] != nums[read - 1])
                {
                    nums[write] = nums[read];
                    write++;
                }
            }

            return write; // number of unique elements
        }

        public static void calc_mov_avg(int size, int[] vect, int windowSize)
        {
            // Set the size of the result array
            int n = size - windowSize + 1;
            int[] result;
            // Check for special case when window size is 1
            if (windowSize == 1)
            {
                // Set the result array to be a copy of the input array
                result = new int[size - windowSize + 1];
                Array.Copy(vect, result, size);
                return;
            }

            result = new int[size - windowSize + 1];
            int sum = 0;

            // Calculate the initial sum of the first window
            for (int i = 0; i < windowSize; i++)
            {
                sum += vect[i];
            }

            // Set the first result
            result[0] = (int)(Math.Ceiling((double)sum / windowSize));

            // Calculate the moving averages for the remaining windows
            for (int i = windowSize; i < size; i++)
            {
                sum = sum - vect[i - windowSize] + vect[i];
                result[i - windowSize + 1] = (int)Math.Ceiling((double)sum / windowSize);
            }
        }
    }
}
