using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        HashSet<char> allowedChars = new HashSet<char>(allowed);
        int count = 0;

        foreach (string word in words) {
            if (word.All(ch => allowedChars.Contains(ch))) {
                count++;
            }
        }

        return count;
    }
}
