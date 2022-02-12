public class Solution {
    public int[] SumZero(int n) {
        int[] arr=new int[n];
        if(n <=1)
            return arr;
        int sum=0;
        for(int i=1; i<n; i++){
            sum +=i;
            arr[i-1]=i;
        }
        arr[n-1] =-sum;
        
        return arr;
    }
}