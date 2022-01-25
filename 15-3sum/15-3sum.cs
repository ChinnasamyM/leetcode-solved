public class Solution {
   
     // Below solution will fail when multiple diuplicated zeros
    //HashSet<int> t2set=new HashSet<int>();
    public IList<IList<int>> ThreeSum(int[] nums) {        
        List<IList<int>> res = new List<IList<int>>();
        int len = nums.Length, target=0;
        if(len<=2)
            return res;
        //Array.Sort(nums);
        //HashSet<int> dups=new HashSet<int>();
        Dictionary<int, int> dups = new Dictionary<int, int>();
        Dictionary<int, int> seen = new Dictionary<int, int>();
        //Dictionary<int, int> dd = new HashSet();
        HashSet<string> tset=new HashSet<string>();
        for(int i=0; i<len; ++i){
            int t=0;
            if(true || dups.TryGetValue(nums[i], out t) !=true){ //
                //dups.Add(nums[i], i);
                for(int j= 0; j<len && i!=j; ++j){ // TWO SUM value
                    int find = target - nums[i] - nums[j];
                    int temp=0;
                    if(seen.TryGetValue(find, out temp ) && temp !=i && temp !=j){
                        List<int> triplet = new List<int>();
                        triplet.Add(nums[i]);
                        triplet.Add(nums[j]);
                        triplet.Add(find);                        
                        triplet.Sort(); //
                        string str = triplet[0].ToString() + triplet[1].ToString() + triplet[2].ToString();  
                        //nums[i].ToString() + nums[j].ToString() + find.ToString();
                        if(!tset.Contains(str)){
                            res.Add(triplet);
                            tset.Add(str);
                        }
                    }                    
                    if(!seen.TryGetValue(nums[j], out temp)){
                        seen.Add(nums[j], j);
                    }
                }
            }
        }
       
        return res;
        
    }
    
    
    
}

// perfect working solution

 /*
        int i=0, j=1, k=len-1;
        while(i<len && k>=0 && j<len && i!=j){
            string strval= nums[i].ToString()+ nums[j].ToString() + nums[k].ToString();
            if(i!=j && i!=k && j!=k && j!=i)
                if(nums[i] + nums[j] + nums[k] ==target && !set.Contains(strval))
                {
                   res.Add(new List<int>{nums[i], nums[j], nums[k] });
                   set.Add(strval); 
                }
            //if(j+2<len)
            j+=2;
            i++;
            k--;            
        }
        */