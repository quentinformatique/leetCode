public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode currNode = head;
        ListNode prevNode = null;
        ListNode nextNode;

        while(currNode != null)
        {
            nextNode = currNode.next;
            currNode.next = prevNode;
            prevNode = currNode;
            currNode = nextNode;
        }

        return prevNode;
    }
}