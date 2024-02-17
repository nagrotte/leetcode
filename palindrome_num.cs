//Palindrome
/*
Given an integer x, return true if x is a 
palindrome
, and false otherwise.

 

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
*/
public class palindrome_num{

public static bool IsPalindrome(int num){

    int reverse_num = 0;
    int original_num = num;
    while(num>0){
    
    int last_digit = num%10;
    reverse_num = reverse_num *10 + last_digit;
    Console.WriteLine($"reverse_num :  {reverse_num}");
    num = num/10;
    }
    return reverse_num==original_num;

}



}

