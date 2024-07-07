public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        var count = numBottles;

        while (numBottles >= numExchange) {
            count += numBottles / numExchange;
            numBottles = (numBottles / numExchange) + (numBottles % numExchange);
        }
        return count;
    }
}