public class Solution {
    public int[] XorQueries(int[] arr, int[][] queries) {
        int len = arr.Length;
        int[] result =  new int[queries.Length];
        int[] preXor = new int[len];

        // compute prefix sum xor
        preXor[0] = arr[0];
        for (int i = 1; i < len; i++) {
            preXor[i] = preXor[i - 1] ^ arr[i];
        }

        for (int i = 0 ; i < queries.Length ; i ++) {
            if (queries[i][0] == 0) {
                result[i] = preXor[queries[i][1]]; // XOR from index 0 to right
            } else {
                result[i] = preXor[queries[i][1]] ^ preXor[queries[i][0] - 1];  // XOR from left to right
            }
        }
        return result;
    }
}