public class Solution
    {
        public string RearrangeString(string s, int k)
        {
            int[] lastIndices = new int[26];
            (char c, int count)[] data = new (char c, int count)[26];

            for (int i = 0; i < 26; i++)
            {
                lastIndices[i] = -1;
                data[i] = ((char) ('a' + i), 0);
            }

            foreach (var c in s)
            {
                data[c - 'a'] = (c, data[c - 'a'].count + 1);
            }

            StringBuilder sb = new StringBuilder(s.Length);

            while (sb.Length != s.Length)
            {
                int current = sb.Length;
                Array.Sort(data, (d1, d2) =>
                {
                    var countCmp = d2.count.CompareTo(d1.count);
                    if (countCmp != 0)
                    {
                        return countCmp;
                    }

                    var idxCmp = lastIndices[d2.c - 'a'].CompareTo(lastIndices[d1.c - 'a']);
                    if (idxCmp != 0)
                    {
                        return idxCmp;
                    }

                    return d1.c.CompareTo(d2.c);
                });

                int idx = 0;
                while (idx != 26 && (data[idx].count == 0 || (lastIndices[data[idx].c - 'a'] >= 0 && current - lastIndices[data[idx].c - 'a'] < k)))
                {
                    idx++;
                }

                if (idx == 26)
                {
                    return string.Empty;
                }

                lastIndices[data[idx].c - 'a'] = current;
                data[idx] = (data[idx].c, data[idx].count - 1);
                sb.Append(data[idx].c);
            }

            return sb.ToString();
        }
    }
/*
public class Solution {
    public string RearrangeString(string s, int k) {
        int len = s.Length; 
        if(len==0 || k==0)
            return "";
        string res="";
        Dictionary<char, int> dict = new Dictionary<char, int>();
        Dictionary<char, int> dict_ext=new Dictionary<char, int>();
        int run=1;
        for(int i=0;i<len; i++){
            int pos;
            if(!dict.TryGetValue(s[i], out pos)){
                dict.Add(s[i], run++);
                res +=s[i];
                
            }
            else if(dict.TryGetValue(s[i], out pos) && run-pos>=k){
                res +=s[i];
                dict[s[i]]=run++;
                    
            }
            else if(dict_ext.TryGetValue(s[i], out pos)){
                dict_ext[s[i]] = pos+1;
                //dict.Add(s[i], run++);
                //res +=s[i];                
            }
            else{
                dict_ext.Add(s[i], 1);
            }
            
            //checking extra char dict
            foreach(KeyValuePair<char, int> kv in dict_ext){
                if(dict.TryGetValue(kv.Key, out pos) && run-dict[kv.Key]>=k){
                    res +=kv.Key;
                    dict[kv.Key] = run++;                    
                    //removal
                    if(pos==1)
                        dict_ext.Remove(kv.Key);
                    else{
                        pos--;
                        dict_ext[kv.Key] = pos;
                    }
                }
            }
        }
        Console.WriteLine("len={0} , string={1}", run, res);
        if(run-1==len)
            return res;
        else 
            return "";
    }
}
*/