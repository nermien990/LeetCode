public class Solution {
    public int[] SortedSquares(int[] nums) {
        for(int i = 0; i < nums.Length; i ++)
        {
            nums[i] = nums[i] * nums[i];
        }
        
        for (int i = 1; i < nums.Length; ++i) {
            int key = nums[i];
            int j = i - 1;
 
            while (j >= 0 && nums[j] > key) {
                nums[j + 1] = nums[j];
                j = j - 1;
            }
            nums[j + 1] = key;
        }
        
        return nums;
    }
}