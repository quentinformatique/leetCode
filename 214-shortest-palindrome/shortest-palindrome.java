class Solution {
  public String shortestPalindrome(String s) {
    final String t = new StringBuilder(s).reverse().toString();
    for (int i = 0; i < t.length(); i++) {
      // Check if the original string 's' starts with the current suffix of 't'
      if (s.startsWith(t.substring(i))) {
        // If a matching prefix-suffix is found, return the result by adding
        // the unmatched part of 't' to the front of 's' to form the palindrome
        return t.substring(0, i) + s;
      }
    }
    // if no sub - palidromes found, concat s and t
    return t + s;
  }
}