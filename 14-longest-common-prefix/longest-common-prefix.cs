public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string s = "";
        for (int i = 0; i < strs[0].Length; i++) {
            for (int j = 1; j < strs.Length; j++) {
                if (i >= strs[j].Length || strs[j][i] != strs[0][i]) {
                    return s;
                }
            }
            s += strs[0][i];
        }
        return s;
    }
}