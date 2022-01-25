public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {        
        List<IList<int>> res = new List<IList<int>>();
        int len = nums.Length, target=0; // target * -1 is required if target!=0
        if(len<=2)
            return res;
        Dictionary<int, int> seen = new Dictionary<int, int>();
        HashSet<string> tset=new HashSet<string>();
        for(int i=0; i<len; ++i){
                for(int j= 0; j<len && i!=j; ++j){ // TWO SUM problem concept with found triplet sorted using array.Sort
                    int find = target - nums[i] - nums[j]; // potental match calc
                    int temp=0;
                    if(seen.TryGetValue(find, out temp ) && temp !=i && temp !=j){ // retrive it from stored hash value
                        List<int> triplet = new List<int>();
                        triplet.Add(nums[i]);
                        triplet.Add(nums[j]);
                        triplet.Add(find);                        
                        triplet.Sort(); // Sorting is required to maintain unique values of each elements-set
                        string str = triplet[0].ToString() + triplet[1].ToString() + triplet[2].ToString();
                        if(!tset.Contains(str)){
                            res.Add(triplet);
                            tset.Add(str);
                        }
                    }  
                    // as we are into n^2 complexity ist possible same value insert hence avoid them using below dictionary check
                    if(!seen.TryGetValue(nums[j], out temp)){
                        seen.Add(nums[j], j);
                    }
                }
            
        }
        return res;
    }   
    
}