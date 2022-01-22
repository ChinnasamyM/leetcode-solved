/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        ListNode l3=null; ListNode head=null; int value=0, carry=0;
        while(l1 !=null || l2 !=null){
            if(l1 !=null && l2 !=null)
                value = l1.val + l2.val + carry; 
            else if(l1 !=null && l2 ==null)
                value = l1.val + carry;
            else if(l1 == null && l2 !=null)
                value = l2.val + carry;
            
            // carry calculation
            if(value>9)
                carry = value/10;
            else
                carry=0;
            
            // result LL
            if(l3!=null){
                ListNode ll = new ListNode(value%10);
                l3.next=ll;
                l3=ll;
            }
            else {
                l3 = new ListNode( value%10);
                head =l3;
            }
            
            if(l1 !=null)
                l1=l1.next;
            if(l2 !=null)
                l2=l2.next;
            
        }
        if(carry !=0){
            ListNode ll=new ListNode(carry);
            l3.next=ll;
        }
        
        
        return head;
    }
}