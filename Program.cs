class Program {
    static void Main(string[] args) {
    /*Two Sum*/
    int[] nums = {7,8,9,10};
    int target = 17;
    int[] result = two_sum.TwoSum(nums, target);

    if (result.Length==2){

        Console.WriteLine($"Indices:[{result[0]},{result[1]}]");
    }
    else{
         Console.WriteLine($"Indices:Not found");
    }

/*Palindrome num*/
    if (palindrome_num.IsPalindrome(122)){

        Console.WriteLine($"Yes, Palindrome");
        }
    else{

        Console.WriteLine($"No, Not a Palindrome");
        }

/*Palindrome str*/
    if (Palindrome_str.IsPalindrome("NaYN")){

        Console.WriteLine($"Yes, Palindrome");
        }
    else{

        Console.WriteLine($"No, Not a Palindrome");
        }
    
/*Pure Recursion - Memo*/

    Console.WriteLine($"Lattice Paths for a given input using Pure Recursion Memo method :" + PureRecurseMemo.LatticePaths(20,20));    
    

/*Helper Recursion - Memo*/

    RecurseHelperMemo.wrapper("Naga Rotte");

/*RecursionHelperwithoutMemo*/

    RecursionHelperwithoutMemo.wrapper("Nag Rotte"); 


/*Bit Array Sorting*/

    int[] arr = {1,1,0,1,0,0,1,0};
    
    int[] sortedArr = BitArraySorting.BitArraySort(arr); //
    foreach (int num in sortedArr) {
      Console.Write(num + " ");
    }




    }//Main Method

 
 
} //Class


