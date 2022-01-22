public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int len=s.Length;
        int ans=0, i=0, j=0;
        HashSet<char> set=new HashSet<char>();
        
        while(i<len && j<len){
            if(!set.Contains(s[j])){
                set.Add(s[j++]);
                ans=Math.Max(ans, j-i);
            }
            else{
                set.Remove(s[i++]);
            }
        }
        foreach(char c in set){
            Console.Write(c);
        }
         return ans;
    }
}