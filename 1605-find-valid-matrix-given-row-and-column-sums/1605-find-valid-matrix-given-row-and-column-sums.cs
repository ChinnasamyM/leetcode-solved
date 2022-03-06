public class Solution {
    public int[][] RestoreMatrix(int[] rowSum, int[] colSum) {
        int rows=rowSum.Length, cols=colSum.Length;
        int[][] res=new int[rows][];
        for(int i=0; i<rows; i++){
            res[i] = new int[cols];
            for(int j=0; j<cols; j++){
                res[i][j] = Math.Min(rowSum[i], colSum[j]);
                rowSum[i] -= res[i][j];
                colSum[j] -= res[i][j];
            }
        }
        return res;
    }
}