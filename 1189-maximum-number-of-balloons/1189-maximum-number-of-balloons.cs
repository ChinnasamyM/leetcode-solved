public class Solution {
    public int MaxNumberOfBalloons(string text) {
        string match="balloon";
       // HashSet<char> set = new HashSet<char>();
        Dictionary<char, int> dict=new Dictionary<char, int>();
        int count=0;
        if(text.Length < match.Length)
            return count;
        int j=0;int _cnt=0;
        for(int i=0; i<text.Length; i++){
           // Console.Write("i={0} ", text[i]);
            if(match[j]==text[i]){
                //i++;
                j++;
            }
            else{
                //set.Add(text[i]);
                 _cnt=0;
                if(dict.TryGetValue(text[i], out _cnt)){
                    _cnt +=1;
                  //  Console.Write("Exists: {0}:{1} , ", text[i], _cnt);
                    dict[text[i]]=_cnt;
                }
                else{
                    _cnt=1;
                    dict.Add(text[i], _cnt);
                }                
                //i++;
            }
            if(j==match.Length){
                j=0;
                count+=1;
            }
           // i++;
        }
        //Console.WriteLine(j.ToString());
        //Display(dict);
        
        bool isExit=false;
        while(dict.Count>0 && isExit==false){
            _cnt=0;
            if(dict.TryGetValue(match[j], out _cnt)){
                if(_cnt==1)
                    dict.Remove(match[j]);
                else
                    dict[match[j]] = _cnt-1;
                //set.Remove(match[j]);
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
    
    public void Display(Dictionary<char, int> dict){
        foreach(KeyValuePair<char, int> kv in dict){
            Console.WriteLine("{0} : {1} ", kv.Key, kv.Value);
        }
    }
}