public class Solution {
    public int StrStr(string haystack, string needle) {
        
        if(String.IsNullOrEmpty(needle) || haystack == needle)
            return 0;        
        int len = haystack.Length - needle.Length;
        if(len<=0 )
            return -1;
        int i=0, j=0, found=-1;
        while(i<=len){
            j=i;int k=0;
            while(k<needle.Length && haystack[j] == needle[k]){
                if(found==-1)
                    found=i;
                j++;k++;
            }
            //Console.WriteLine("j={0}, k={1}, found={2}", j, k, found);
            if(found>=0 && k==needle.Length) // this base case condition is most important, note k, j are incremented with additional one pointer in the previous loop. Hence  
                return found;
            else 
                found =-1;
            i++;
        }
        
        return found;
    }
}