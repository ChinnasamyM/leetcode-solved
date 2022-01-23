public class Solution {
    public int NumPairsDivisibleBy60(int[] time) {
        int counter=0;
        /*
        HashSet<string> set= new HashSet<string>();
        for(int i=0; i<time.Length; i++){
            for(int j=0; j<time.Length; j++){
                if(i!=j && (time[i] + time [j]) % 60 ==0 && !set.Contains(j.ToString() + "," + i.ToString()) && !set.Contains(i.ToString() + "," + j.ToString()) ){
                    counter += 1;
                    set.Add(j.ToString() + "," + i.ToString());
                }
            }
        }
        return counter;
        */
        int[] rem = new int[60];
        for(int i=0; i<time.Length; i++){
            if(time[i] % 60==0)
                counter += rem[0];
            else
                counter += rem[60-time[i] % 60];
            rem[time[i] % 60] ++;
        }
        return counter;
    }
}