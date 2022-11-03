namespace Tasks;
public class RemoveDuplicatesFromSortedArray {
    public int RemoveDuplicates(int[] nums) {
        int temp = 1; 
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] != nums[i - 1])
            {
                nums[temp] = nums[i];
                temp++;
            }      
        }
        return temp;
    }
}