public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        double mean;
        int i=0;
        int j=0;
        List<int> merged = new List<int>();

        while (i<nums1.Length && j<nums2.Length) {
            if (nums1[i] < nums2[j]) {
                merged.Add(nums1[i]);
                i++;
            }
            else {
                merged.Add(nums2[j]);
                j++;
            }
        }

        while (i<nums1.Length) {
            merged.Add(nums1[i]);
            i++;
        }
        
        while (j<nums2.Length) {
            merged.Add(nums2[j]);
            j++;
        }

        if (merged.Count % 2 == 0) {
            return ((merged[merged.Count/2] + merged[merged.Count/2 - 1])/2.0);
        } else {
            return ((merged[merged.Count/2]));
        }

    }
}

