/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution {
    public Node Flatten(Node head) {
        //List<Node> childs=new List<Node>();
        if(head ==null)
            return head;
        
        Node node = head;
        Stack<Node> stk = new Stack<Node>();
        stk.Push(node);// push the initial node to stack
        while(stk.Count!=0){ // run the loop until stack empty.
            node = stk.Pop();// Assign the last stacked node to var->node
            if(node.next !=null)
                stk.Push(node.next);
            else if(stk.Count !=0){ // when linking the child of list to current node
                node.next = stk.Peek();
                stk.Peek().prev = node;
            }
            if(node.child != null){ // if child exists then push it to stack 
                stk.Push(node.child);
                node.next = node.child;
                node.child.prev = node;
                node.child = null;
            }
        }        
        return head; // whole ops are in same memeory of LL object.
    }
    /* // recursive method
     private void SetNext(Node head)
    {
        Node next = head.next;
        last = head;
        if(head.child != null)
        {            
            SetNext(head.child);
            head.next = head.child;
            head.next.prev = head;
            head.child = null; 
        }
        if(next != null) 
        {
            last.next = next;
            next.prev = last;            
            SetNext(next);
        }
    }
    */
    
}