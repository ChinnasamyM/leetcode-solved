public class Solution
{
    public int UniqueLetterString(string s)
    {
        int?[,] index = new int?[26,2];

        int res = 1;
        
        int cur = 1;
        
        index[s[0] - 'A',1] = 0;
        
        for (int i = 1; i < s.Length; i++)
        {
            int ch = s[i] - 'A';
            
            cur -= index[ch,1].HasValue ? index[ch,1].Value - index[ch,0].GetValueOrDefault(-1) : 0;                            
            cur += i - index[ch,1].GetValueOrDefault(-1);
            
            res += cur;
            
            index[ch,0] = index[ch,1];
            index[ch,1] = i;
        }
        
        return res;
    }
}