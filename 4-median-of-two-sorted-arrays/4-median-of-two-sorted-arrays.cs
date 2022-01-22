public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        //int len=Math.Max(nums1.Length, nums2.Length);
        //int[] res= new int[len];
        int lenA=nums1.Length;
        int lenB=nums2.Length;
        if(lenA>lenB){
            Swap(ref nums1, ref nums2);
            Swap(ref lenA, ref lenB);
        }
        int halfLen=(lenA + lenB +1)/2;
        int minCountA=0, maxCountA=lenA;
        while(minCountA<=maxCountA){
            int countA=minCountA + ((maxCountA - minCountA)/2);
            int countB=halfLen - countA;
            
            int? x= countA>0 ? nums1[countA -1] : (int?)null;            
            int? y= countB>0 ? nums2[countB-1] : (int?)null;
            
            int? xp= countA<lenA ? nums1[countA] : (int?)null;
            int? yp= countB<lenB ? nums2[countB] : (int?)null;
            
            if(x>yp)
                maxCountA=countA-1;
            else if(y>xp)
                minCountA=countA+1;
            else{
                int leftHalfEnd = (x==null) ? y.Value 
                        : (y==null ? x.Value : Math.Max(x.Value, y.Value));
                
                if(IsOdd(lenA + lenB))
                    return leftHalfEnd;
                
                int rightHalfStart = (xp==null) ? yp.Value 
                        : (yp==null) ? xp.Value : (Math.Min(xp.Value, yp.Value));
                return (leftHalfEnd + rightHalfStart) / 2.0;
            }
        }
        return 0.0;
        
    }
    
    private void Swap<T>(ref T a, ref T b){
        T tmp=a;
        a=b;
        b=tmp;
    }
    
    private bool IsOdd(int x)=>(x&1)==1;
}