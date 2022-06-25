public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int min = 0;
        int max = nums.Length - 1;
        int mid = 0;
        int pos = -1;
        while(min <= max){
            mid = (min + max) / 2;
            if(target == nums[mid])
            {
                return mid;
            }
            else if(target < nums[mid])
            {
                max = mid -1;
                pos = mid;
            }
            else
            {
                min = mid + 1;
                pos = mid +1;
            }
        }
        return pos ;
    }
}