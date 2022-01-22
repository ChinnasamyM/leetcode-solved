public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> dict=new Dictionary<char, char>();
        dict.Add(')', '(');
        dict.Add('}', '{');
        dict.Add(']', '[');
        List<char> stk=new List<char>();
        
        for(int i=0; i<s.Length; i++){
            char letter;
            if(s[i] == '{' || s[i]=='(' || s[i]== '[' )
                stk.Add(s[i]);
            else if(dict.TryGetValue(s[i], out letter)){
                    if(stk.Count>0 && dict.TryGetValue(s[i], out letter) && stk[stk.Count-1]==letter)
                        stk.RemoveAt(stk.Count-1);
                    else 
                        return false;    
            }
        }
        if(stk.Count==0)
            return true;
        else 
            return false;
        
    }
}