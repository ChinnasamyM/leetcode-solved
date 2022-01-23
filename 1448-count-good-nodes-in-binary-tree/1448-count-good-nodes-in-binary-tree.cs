/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int GoodNodes(TreeNode root) {
        return countGoodNodes(root, root.val);
    }
    
    private int countGoodNodes(TreeNode node, int maxSoFar){
        int noOfGoodNodes=0;
        
        if(node !=null) {
            if(node.val >= maxSoFar){
                maxSoFar = node.val;
                noOfGoodNodes ++;
            }
            
            noOfGoodNodes += countGoodNodes(node.left, maxSoFar);
            noOfGoodNodes += countGoodNodes(node.right, maxSoFar);
        }
        
        return noOfGoodNodes;
    }
}