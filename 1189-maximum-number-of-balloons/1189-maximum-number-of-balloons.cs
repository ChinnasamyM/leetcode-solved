public class Solution {
    public int MaxNumberOfBalloons(string text) {
        string match="balloon";
        Dictionary<char, int> dict=new Dictionary<char, int>();
        int count=0;
        if(text.Length < match.Length)
            return count;
        int j=0;int _cnt=0;
        for(int i=0; i<text.Length; i++){
            if(match[j]==text[i]){
                j++;
            }
            else{
                 _cnt=0;
                if(dict.TryGetValue(text[i], out _cnt)){
                    _cnt +=1;
                    dict[text[i]]=_cnt;
                }
                else{
                    _cnt=1;
                    dict.Add(text[i], _cnt);
                }    
            }
            if(j==match.Length){
                j=0;
                count+=1;
            }
        }
        
        bool isExit=false;
        while(dict.Count>0 && isExit==false){
            _cnt=0;
            if(dict.TryGetValue(match[j], out _cnt)){
                if(_cnt==1)
                    dict.Remove(match[j]);
                else
                    dict[match[j]] = _cnt-1;
                j++;
            }
            else
                isExit=true;
            if(j==match.Length){
                j=0;
                count+=1;
            }
        }
        return count;
        
    }
}