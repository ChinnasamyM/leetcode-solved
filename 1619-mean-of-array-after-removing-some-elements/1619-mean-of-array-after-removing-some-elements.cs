public class Solution {
    public double TrimMean(int[] arr) { 
        /*Note:
        1.  Without sorting is makes to store in dictionary and subtract the minumum number elemets and maximum percent number of element by search. in order to avoid complexity in storage and hashing better to sort.
        
        2. Loop starts from min 5% th poistion ie., from target and ends at len=Array.Length - target.
        3. If new Length is <= tagrget ie., 5 % value then the sum would come 0.
        4. Two time of target number of elements will be removed.
        */
        Array.Sort(arr);       
        int target = arr.Length * 5 /100;
        int len = arr.Length - target;
        if(target>=len)
            return 0;
        double sum = 0;
        for(int i=target; i < len; i++) {
          sum += arr[i]; 
        }
        int count = arr.Length - (target *2);
        return sum/count;
                
    }
}