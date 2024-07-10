public class Solution {
    public int MinOperations(string[] logs) {
        int moves = 0;
        for (int i = 0 ; i < logs.Length ; i ++) {
            if (logs[i] == "../")
            {
                if (moves > 0) {
                    moves--;
                }
            }
            else if (logs[i] != "./")
            {
                moves ++;
            }
        }
        return moves;
    }
}