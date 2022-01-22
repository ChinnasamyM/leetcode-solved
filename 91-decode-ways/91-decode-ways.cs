public class Solution {
    public int NumDecodings(string s) {
        // The compiler treats char A=65 and Z=90
        // A=1 then Z=26
        /* As the DP is a way to calculate all the previous value and store in current position.
        While you recalcualte any other value alsway check its previous value.
        hence dp[i-1] is always required.
        */
        int n=s.Length;
        if(n==0 || s[0]=='0') // edge cases ie., s="", s="0", s="06"
            return 0;/*
        else if(n==1 && s[0]=='0') // edge case 2
            return 0;
        else if(s[0]=='0')
            return 0;*/
        int[] dp=new int[n+1];
        dp[0] =1;
        dp[1] =s[0] !=0? 1 : 0; // if length is 1 then possibility is 1
        for(int i=2; i<=n; i++){
            int first = Convert.ToInt32(s.Substring(i-1, 1));
            int second = Convert.ToInt32(s.Substring(i-2, 2));
            if(first >0 && first <=9)
                dp[i] += dp[i-1];
            if(second >9 && second <=26)
                dp[i] += dp[i-2];
            
        }
        
        return dp[n];
    }
}