class Program {
    static void Main(string[] args) {
    
    int[] nums = {7,8,9,10};
    int target = 17;
    int[] result = two_sum.TwoSum(nums, target);

    if (result.Length==2){

        Console.WriteLine($"Indices:[{result[0]},{result[1]}]");
    }
    else{
         Console.WriteLine($"Indices:Not found");
    }
}
}

