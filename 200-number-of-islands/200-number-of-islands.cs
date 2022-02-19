public class Solution {
    public int NumIslands(char[][] grid) {
        //program to return number of Islands
        int _count=0;
        int row=grid.Length;
        int col;        
        for(int i=0; i<row; i++){
            col=grid[i].Length;
            for(int j=0; j<col; j++){
                if(grid[i][j] == '1'){
                   mark_island(ref grid, i, j, row, col);
                    _count +=1;
                }
            }
        }  
        return _count;
    }
   void mark_island(ref char[][] grid, int x, int y, int r, int c) {
        if(x<0 || x>=r || y<0 || y>=c || grid[x][y]!='1') {
            return;
        }            
       grid[x][y] = '2'; // runs upto end of its search ie., both DFS for x and BFS for y value. 
       mark_island(ref grid, x+1, y, r, c); // down // Loop never ends until the base condition met on the line 21/1
       mark_island(ref grid, x-1, y, r, c); // up
       mark_island(ref grid, x, y+1, r, c); // right
       mark_island(ref grid, x, y-1, r, c); // left
    }
}