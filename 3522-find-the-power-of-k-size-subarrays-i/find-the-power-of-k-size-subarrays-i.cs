public class Solution {
    public int[] ResultsArray(int[] nums, int k) {
        if (k == 1) return nums;
        
        int n = nums.Length;
        var result = new List<int>();
        var window = new Queue<int>();
        
        for (int i = 0; i < n; i++) {
            while (window.Count > 0 && i - window.Peek() >= k) {
                window.Dequeue();
            }
            
            if (window.Count == 0 || nums[i] - nums[i-1] == 1) {
                window.Enqueue(i);
            } else {
                window.Clear();
                window.Enqueue(i);
            }
            
            if (i >= k-1) {
                result.Add(window.Count == k ? nums[i] : -1);
            }
        }
        
        return result.ToArray();
    }
}