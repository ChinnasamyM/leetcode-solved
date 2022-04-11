public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        int len = isConnected.Length;
        int[] parent= new int[len];
        parent = arrayFill(parent, -1);
        
        for(int j =0; j<len; j++){
            for(int k=0; k<len; k++){
                if(isConnected[j][k]==1 && j!=k)
                    union(parent, j, k);
            }
        }
        
        int count = 0;
        for(int i=0; i<len; i++)
            if(parent[i]==-1)
                count++;
        return count;
        
    }
    
    int find(int[] parent, int i){
        if(parent[i]==-1)
            return i;
        return find(parent, parent[i]);
    }
    
    void union(int[] parent, int x, int y){
        int xset = find(parent, x);
        int yset = find(parent, y);
        if(xset != yset)
            parent[xset] = yset;
    }
    
    int[] arrayFill(int[] parent, int value){
        for(int i=0; i<parent.Length; i++)
            parent[i] = value;
        return parent;
    }
    
}