public class Solution {
    public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts) {
        //double maxH = 0; // getMaxCutts( h, horizontalCuts);
        //double maxV = 0; // getMaxCutts( w, verticalCuts);
        long mod = 1000000000 +7; // (Math.Pow(10, 9) +7);
        
        Array.Sort(horizontalCuts);
        Array.Sort(verticalCuts);
        
        int maxL= Math.Max(h- horizontalCuts[horizontalCuts.Length-1], horizontalCuts[0]);
        for(int i=1; i<horizontalCuts.Length; i++)
            maxL = Math.Max(horizontalCuts[i] - horizontalCuts[i-1], maxL);
        
        int maxW= Math.Max(w - verticalCuts[verticalCuts.Length-1], verticalCuts[0]);
        for(int i=1; i<verticalCuts.Length; i++)
            maxW = Math.Max(verticalCuts[i] - verticalCuts[i-1], maxW);
        
        //long res = ((long)maxL * (long)maxW );
        return (int) ( ((long)maxL * (long)maxW ) % mod);
        
        
        /*
        int lastCut=0;
        foreach(int idx in horizontalCuts){
            maxL = Math.Max(maxL, idx - lastCut);
            lastCut = idx;
        }       
        maxL = Math.Max(maxL, h-lastCut);
        
        lastCut=0;
        foreach(int idx in verticalCuts){
            maxW = Math.Max(maxW, idx - lastCut);
            lastCut = idx;
        }
        maxW = Math.Max(maxW, w - lastCut);
        
        return (int) ((maxL * maxW) % 1000000007); // (Math.Pow(10, 9) +7)
        */
    }
    /*
    public double getMaxCutts(int max, int[] cutts){
                
        Array.Sort(cutts);
        
        var diff = 0; int maxdiff=0;
        for(int i=0; i<=cutts.Length; i++){
            if(i==0)
                diff = cutts[i];
            else if(i==cutts.Length)
                diff = max - cutts[i-1];
            else
                diff = cutts[i] - cutts[i-1];
           maxdiff = maxdiff<diff ? diff : maxdiff;
        }
        return Convert.ToDouble(maxdiff);
        
    } */
}