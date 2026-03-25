public class Solution {
    public int MaxArea(int[] height) {
        int answer = 0;

        int largest = 0;
        int count = 0;
        int left = 0;
        int right = height.Length - 1;
        int width;

        while (left < right) {
            width = right - left;
            largest = width * Math.Min(height[left], height[right]);

            if (height[left]>height[right]) {
                right--;
                count++;
            } else {
                left++;
                count++;
            }
            if (largest > answer) {
                answer = largest;
            }
        }
        return answer;
    }
}
