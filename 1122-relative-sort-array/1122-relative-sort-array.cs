public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        Dictionary<int, int> dict=new Dictionary<int, int>();
        int[] res=new int[arr1.Length];
        for(int i=0; i<arr1.Length; i++){
            int o_value=0;
            if(dict.TryGetValue(arr1[i], out o_value)){
                dict[arr1[i]] = o_value +1;
            }
            else {
                dict.Add(arr1[i], 1);
            }
        }
        int r_count=0;
        for(int j=0; j<arr2.Length; j++){
            int count=0;
            if(dict.TryGetValue(arr2[j], out count)){
                //int count=dict[arr2[j]];
                while(count>0){
                    res[r_count++] = arr2[j];
                    count--;
                }
                dict.Remove(arr2[j]);
            }
        } // now the res[] array will have the relatively ordered elements stored per contsraints given.
        foreach(KeyValuePair<int, int> kv in dict.OrderBy(k=> k.Key)){
            int t_count=kv.Value;
            while(t_count>0){
                res[r_count++]=kv.Key;
                t_count--;
            }
        }
        return res;
    }
}