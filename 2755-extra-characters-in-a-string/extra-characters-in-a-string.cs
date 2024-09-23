public class Solution {
    public int MinExtraChar(string s, string[] dictionary) {
        ISet<string> set = new HashSet<string>(dictionary.Length);
        IDictionary<int, int> indexAnswerCache = new Dictionary<int, int>();
        int maxWord = 0;
        foreach(var word in dictionary) {
           set.Add(word) ;
           maxWord = Math.Max(maxWord, word.Length);
        }

        int dfs (int index) {
            if (index == s.Length)
                return 0;
            
            if (indexAnswerCache.ContainsKey(index))
                return indexAnswerCache[index];

            int ans = 1 + dfs(index + 1);
            // Search word
            for (int j = index; j <= index + maxWord && j < s.Length; j++) {
                if (set.Contains(s.Substring(index, j + 1 - index)))
                    ans = Math.Min(ans, dfs(j + 1));
                
            }

            indexAnswerCache[index] = ans;
            return indexAnswerCache[index];
        }

        return dfs(0);
    }
}