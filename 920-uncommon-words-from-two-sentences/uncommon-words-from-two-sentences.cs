public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        string full = s1 + ' ' + s2;
        string[] subs = full.Split(' ');
        
        return subs.GroupBy(w => w)
                   .Where(g => g.Count() == 1)
                   .Select(g => g.Key)
                   .ToArray();
    }
}