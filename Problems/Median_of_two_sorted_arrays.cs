﻿namespace Problems
{
    public class Median_of_two_sorted_arrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] mergedArray = Merge(nums1, nums2);

            if (mergedArray.Length % 2 == 1)
                return mergedArray[mergedArray.Length / 2];
            else
                return (mergedArray[mergedArray.Length / 2] + mergedArray[mergedArray.Length / 2 - 1]) / 2.0;

            int[] Merge(int[] nums1, int[] nums2)
            {
                int[] result = new int[nums1.Length + nums2.Length];
                int i = 0, j = 0;
                while (i < nums1.Length || j < nums2.Length)
                {
                    if (i < nums1.Length && j < nums2.Length)
                    {
                        if (nums1[i] <= nums2[j])
                        {
                            result[i + j] = nums1[i];
                            i++;
                        }
                        else
                        {
                            result[i + j] = nums2[j];
                            j++;
                        }
                        continue;
                    }

                    if (i < nums1.Length)
                    {
                        result[i + j] = nums1[i];
                        i++;
                        continue;
                    }

                    if (j < nums2.Length)
                    {
                        result[i + j] = nums2[j];
                        j++;
                        continue;
                    }
                }
                return result;
            }
        }
    }
}
