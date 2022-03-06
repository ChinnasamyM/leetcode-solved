public class Solution {
    public double TrimMean(int[] arr) {
        Array.Sort(arr);
        
        int i = arr.Length * 5 /100;
        int j = arr.Length - i;
        
        double val = 0;
        
        for(int k=i; k < j; k++) {val += arr[k]; }
        return (i>=j)? 0 : val/(j-i);
    }
}