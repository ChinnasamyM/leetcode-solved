public class Solution {
    public string IntToRoman(int num) {
        
        if(num>=4000 || num <=0)
            return "";
        
        //Simplistic solution =>
        /*
        Stored char are being retrived from the result of % and / ops....
        
        Example: num=1230
        1230/1000=1
        1230%1000 = 230 => /100 => 2 
        1230%100 = 30 => /10 => 3
        1230%10 = 0 => 0
        */
        string[] I = {"","I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"}, 
                 X = {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX","LXXX", "XC" },
                 C = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"},
                 M = {"", "M", "MM", "MMM"};
        return M[(num/1000)] + C[(num%1000)/100] + X[(num%100)/10] + I[num%10];
        
        // Solution 2
        
    }
}

/*
Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
*/