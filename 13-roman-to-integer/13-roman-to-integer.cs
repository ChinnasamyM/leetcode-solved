public class Solution {
    public int RomanToInt(string s) {
        Dictionary<string, int> dict=new Dictionary<string, int>(){
            //{"", 0}, // no zero in roman numbers
            {"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000}
        };
        
        
        int n=s.Length;
        int last_val=dict[s[n-1].ToString()], curr_val=0;
        int res=0;
        res += last_val;
        for(int i=s.Length-2; i>=0; i--){
            curr_val = dict[s[i].ToString()];
            if(curr_val<last_val) // its per design when preceeding value is lower than curr_val then deduct it from its constant val.
                res -= curr_val;
            else 
                res += dict[s[i].ToString()];
            last_val = curr_val;
        }
        return res;
    }
}