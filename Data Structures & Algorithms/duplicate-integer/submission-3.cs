public class Solution {
    public bool hasDuplicate(int[] nums) {
        int counter = 0;
        Dictionary<int, int> hashTable = new Dictionary<int, int>();
        
        for(int i=0; i < nums.Length; i++){
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[i] - nums[j] == 0){
                    return true;
                }
            }           
        }
        return false;
        
    }
}