using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        decimal positive = 0;
        decimal negative = 0;
        decimal zeros = 0;
        
        for(int i=0; i < arr.Count; i++) 
        {
            if(arr[i] > 0) {
                positive +=1;
            } else if(arr[i] == 0){
                zeros +=1;
            } else {
                negative +=1;
            }
        }
        
        Console.WriteLine($"{positive/arr.Count:F6}"); / String Interpolation Operator C#6 for decimal variables => :Fn 
        Console.WriteLine($"{negative/arr.Count:F6}");
        Console.WriteLine($"{zeros/arr.Count:F6}");
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
