using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    // 1) Basic Conditional Sum 
    static int solveMeFirst(int a, int b) { 
      // Hint: Type return a+b; below  
        if(1 <= a && b <= 1000)
            return a+b;
        return a+b;
    }

    static void Main(String[] args) {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        int sum = solveMeFirst(val1,val2);
        Console.WriteLine(sum);
    }
}      
