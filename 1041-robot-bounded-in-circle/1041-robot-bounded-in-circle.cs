public class Solution {
    public bool IsRobotBounded(string instructions) {
        /*
                N
                |
                |
                |
        W------------------E
                |
                |
                |
                S
        Direction=N, L=Left, R=Right, G=1 -> Go
        Example: GGLLGG = True
        */      
        
        /*
        int a=0, b=0, move=0; // dir=> 0=North, 1=East, 2=South, 3=west
        //int[,] dir = new int[4,2] { {1,0}, {0,1}, {-1,0}, {0,-1} };        
        foreach(char c in instructions){
            if(c=='G'){
                if(move==0)
                    a++;
                else if(move==1)
                    b++;
                else if(move==2)
                    a--;
                else if(move==3)
                    b--;
            }                
            else if(c=='L'){
             move = (4 + move - 1) % 4; //move = move==3? 0 : move-1;  
            }
            else if(c=='R')
                move = (move +1) % 4;                
        }
        return (a==0 && b==0) || move !=0;           
       */
        // Below solution works only 70% of test cases..
        /*
        int dirX=0, dirY=0;
        int x=0, y=0;
        int temp;
        foreach(char cmd in instructions){
            if(cmd =='G'){
                x+=dirX;
                y+=dirY;
            }
            else if(cmd=='L'){
                temp = dirX;
                dirX = -1*dirY;
                dirY = temp;
            }
            else{
                temp = dirY;
                dirY = -1*dirX;
                dirX = temp;
            }
        }
        
        return (x==0 && y==0) || (dirX !=0 && dirY !=1 );
        */
        
        int x=0, y=0;// int move=0;
        char dir='N'; //int count=0;
        foreach(char c in instructions){
            if(c=='G'){
               // count++;
                if(dir=='N')
                    y++;
                else if(dir=='E')
                    x++;
                else if(dir=='W')
                    x--;
                else //if(dir=='S')
                    y--;                
            }
            else if(c=='L'){
                if(dir=='N')
                    dir='W';
                else if(dir=='S')
                    dir='E';
                else if(dir=='W')
                    dir='S';
                else //if(dir=='E')//
                    dir='N';
            }
            else{ // if(c=='R')
                if(dir=='N')
                    dir='E';
                else if(dir=='S')
                    dir='W';
                else if(dir=='W')
                    dir='N';
                else //if(dir=='E')//
                    dir='S';
            }
        }     
        //Console.WriteLine("x={0} y={1}, count={2}", x, y, count);
        return ( x==0 && y==0) || dir !='N'; //( ( y-x <= count/2) && count%2==0 && dir !='N') || count<2 ;      // ((x<=2 && x>=-2 ) && ( y<=2 && y>=-2) && count%2==0) // || dir !='N'  // x==0 && ( y<=2 && y>=-2 && dir!='N')
        
    }
}