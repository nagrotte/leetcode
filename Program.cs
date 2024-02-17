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
    }
}


