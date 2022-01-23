public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        Dictionary<string, int> dict=new Dictionary<string, int>();
        int _count;        
        foreach(string str in words){
             _count=0;
            if(dict.TryGetValue(str, out _count))
                dict[str]=_count+1;
            else
                dict.Add(str,_count+1);
        }
        List<string> str_list=new List<string>();
        int _loop=0;
        foreach(KeyValuePair<string, int> kv in dict.OrderByDescending(key => key.Value).ThenBy(key=>key.Key)){
            if(_loop >=k)
                break;
            str_list.Add(kv.Key);
            _loop+=1;
        }
        return str_list;
        
    }
}