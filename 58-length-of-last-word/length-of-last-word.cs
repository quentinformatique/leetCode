public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        string lastW = s.Split(" ")[^1];
        return lastW.Length;
    }
}