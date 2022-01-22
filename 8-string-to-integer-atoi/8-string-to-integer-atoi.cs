public class Solution {
    public int max=2147483647, min=-2147483648;    
    
    public int MyAtoi(string s) {
        string res=""; 
        bool sign=false, isNegative=false;
        char prev=' ';        
        
        foreach(char c in s){
            if(isDigit(c) || c==' ' || c=='-' || c=='+'){
                if(isDigit(c)){ 
                    res += c;
                    if(!sign && prev=='-'){
                        isNegative=true;
                        sign=true;
                    }
                    else if(!sign){
                       isNegative=false;
                        sign=true; 
                    }  
                }
                // Optimized: Below conditions are formed based on the test case to match the initial requirement
                if( ( sign || prev=='-' || prev=='+') && !isDigit(c) ) { 
                        break;
                }
            }
            else 
                break;
            prev =c;
        }
        //Console.WriteLine(res);
        long num=0; // It must be zero as every digit is calculated by multiplying with 10 or shift ops
        for(int i=0; (i<res.Length && Check(num)); i++){// this Check is to ensure the current value is not overflow/underflow to Intger range of given constraints.
            num = num * 10 + (res[i] - '0'); 
        }
       //Console.WriteLine(num);
        num = isNegative==true? -1*num : num;        
        if(num > max)
            return max;
        else if(num<min)
            return min;
        else 
            return (int)num;
              
    }
    
    public bool Check(long val){
        //num = isNegative==true? -1*num : num;
        if(val > max)
            return false;
        else if(val<min)
            return false;
        else
            return true;
    }
    
    public bool isDigit(char c){return (c>='0' && c<='9') == true? true: false;}
}