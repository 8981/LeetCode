namespace Tasks;

public class TaskRemoveElement {
    public int RemoveElement(int[] nums, int val) {
        int temp = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != val){
                nums[temp] = nums[i];
                temp++;
            }
        }
        return temp;
    }
}