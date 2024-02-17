public class Palindrome_str
{
    public static bool IsPalindrome(string str)
    {
        int len_str = str.Length;
        int left = 0;
        int right = len_str - 1;

        while (left <= right)
        {
            if (str[left] != str[right])
            {
                Console.WriteLine($"str[left] = {str[left]} & str[right] = {str[right]}");
                return false;
            }
            left++; // Increment left pointer
            right--; // Decrement right pointer
        }

        return true; // Return true if no mismatch found
    }
}
