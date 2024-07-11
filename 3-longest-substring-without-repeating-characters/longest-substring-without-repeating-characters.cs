public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // Check if the length of the string is less than 2
        if (s.Length < 2) {
            return s.Length;
        }
        
        // Initialize variables
        int k = 0, maxLen = 0, count = 0;
        
        // Iterate through the string
        for (int i = 1; i < s.Length; i++) {
            // Check for repeating characters in the current substring
            for (int j = k; j < i; j++) {
                if (s[i] == s[j]) {
                    k = j + 1;
                }
            }
            
            // Update the current substring length
            count = i - k + 1;
            
            // Update the maximum length
            if (count > maxLen) {
                maxLen = count;
            }
        }
        
        // Return the result
        return maxLen;
    }
}