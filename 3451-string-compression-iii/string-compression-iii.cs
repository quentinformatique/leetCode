public class Solution {
    public string CompressedString(string word) {
        if (string.IsNullOrEmpty(word)) return "";
        
        StringBuilder comp = new StringBuilder(word.Length * 2);
        
        int cnt = 1;
        char ch = word[0];
        
        for (int i = 1; i < word.Length; i++) {
            if (word[i] == ch && cnt < 9) {
                cnt++;
            } 
            else {
                comp.Append((char)(cnt + '0'));
                comp.Append(ch);
                ch = word[i];
                cnt = 1;
            }
        }
        
        comp.Append((char)(cnt + '0'));
        comp.Append(ch);
        
        return comp.ToString();
    }
}