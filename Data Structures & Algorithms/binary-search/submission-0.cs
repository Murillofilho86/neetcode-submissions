public class Solution {
    public int Search(int[] nums, int target) {
        

        int low = 0;
        int high = nums.Length - 1;

        while(low <= high){
            
            int middle = (low + high) / 2;
            int kick = nums[middle];

            if(kick == target){
                return middle;
            }

            if(kick > target){
                high = middle - 1;
            }else{
                low = middle + 1; 
            }
    
        }

        return -1;
    }
}
