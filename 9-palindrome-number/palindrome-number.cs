public class Solution {
    public bool IsPalindrome(int x) {
        string str = Convert.ToString(x);
        string reverse = "";
        for (int i = str.Length-1; i >= 0; i = i-1) {
            reverse += str[i];
        }
        return reverse == str;
    }
}