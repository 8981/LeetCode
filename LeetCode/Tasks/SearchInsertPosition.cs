namespace Tasks;
public class TaskSearchInsertPosition {
    public int SearchInsert(int[] nums, int target) {
        var start = 0;
        var end = nums.Length - 1;
        while(start + 1 < end){
            var mid = (start + end)/2;
            if(nums[mid] == target)
                return mid;
            if(nums[mid] < target){
                start = mid;
            }else{
                end = mid;
            }
        }
        if(nums[start]>=target){
            return start;
        }else if(nums[end]>=target){
            return end;
        }else{
            return end +1;
        }
    }
}