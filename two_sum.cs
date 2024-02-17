 
 public class two_sum{
 public static int[] TwoSum(int[] nums, int target) {
    
        Dictionary<int, int> found = new();
        //loop through the given input nums
        for (int i=0; i<nums.Length; i++){

            //find the integer if its already touched 
            //Find the integer by subtracting it from target
            int _sub = target - nums[i];

            if (found.ContainsKey(_sub)){

                    return new int[] {found[_sub],i};

            }
            else{

                found.Add(nums[i],i);    

            }

        } 
        return Array.Empty<int>();
    }

 }