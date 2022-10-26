public class Solution {
    // 1- Running-Sum-of-1D-Array
    string arrSumRunner = "0"; 
    int[] replacement;
    public int[] RunningSum(int[] nums) 
    {
        replacement = new int[nums.Length];
            
        if( 1 <= nums.Length && nums.Length <= 1000) 
        {
            for(int i=0; i < nums.Length; i++) 
            {
                this.arrSumRunner = (int.Parse(this.arrSumRunner) + nums[i]).ToString();
                replacement[i] = int.Parse(this.arrSumRunner);
            }
            return replacement;
        }
        return nums;
    }
}

// Next answer (2)

public class Solution {
    // 1- Running-Sum-of-1D-Array
    public int[] RunningSum(int[] nums) 
    {
        for(int i = 1; i < nums.Length; i++) 
        {
           nums[i] = nums[i - 1] + nums[i];
        }
        return nums;
    }
}

// time complexity = O(n)
// space complexity = O(1)
