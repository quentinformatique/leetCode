public class Solution {
    public IList<string> RemoveSubfolders(string[] folder) {
        Array.Sort(folder);
        
        IList<string> ans = new List<string>();
        ans.Add(folder[0]);
        
        for (int i = 1; i < folder.Length; i++) {
            string lastFolder = ans[ans.Count - 1] + "/";
            
            if (!folder[i].StartsWith(lastFolder)) {
                ans.Add(folder[i]);
            }
        }
        
        return ans;
    }
}