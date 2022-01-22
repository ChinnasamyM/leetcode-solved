public class Solution {
    // Two pointers apporach or FCD algorith would work or DP also. 
    public int MaxArea(int[] height) {
        int min=0; //dsInt32.MinValue;
        int area=0;
        int start=0, end=height.Length-1;// array positions
        while(start<end){
            min=Math.Min(height[start], height[end]);// minimum value of two bars are the area where water can be stored is the assuimption for every iteration
            area = Math.Max(area, min*(end-start)); // no.of slot = end-start
            //pointers move for array positions
            if(height[start]<height[end])
                start++;
            else
                end--;
        }
        return area;
    }
}