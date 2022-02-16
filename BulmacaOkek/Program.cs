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
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        List<int> bolenler = new List<int> ();
        List<int> ortaklar = new List<int>();
        a.Sort();
        a.Reverse();
        b.Sort();
        b.Reverse();
        int ortakbolen = 0;
        if(a.Count==1)
        {
            int say=0;
            for (int ii = a[0]; ii <= b[0]; ii++)
            {
                int ix = 0;
             int ickont=0;  
                for(int i = 0; i < b.Count; i++)
                {
                    
                    if(b[i] % ii == 0)
                    {
                        ickont++;
                    }
                    ix = ii;
                }
               if (ickont == b.Count)
                    {
                        say++;
                    ortaklar.Add(ix);
                    }
            }
            List<int> test = ortaklar ;
            return say;
        }
        
        for (int z = a[0]; z < 10000; z++)
        {
            int kt = 0;
            for(int y=0; y<a.Count; y++)
            {
                if (z % a[y] == 0)
                {
                    kt++;
                }
            }
            if(kt == a.Count)
            {
                ortakbolen = z;
                break;
            }

        }
        if (ortakbolen == 0)
        {
            return 0;
        }
       
        for (int i = 0; i < b.Count; i++)
        {
            if (b[i] % ortakbolen == 0)
            {
                bolenler.Add(b[i]);
            }
        }
        return bolenler.Count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);
        Console.WriteLine(total);
        Console.ReadLine();

        //textWriter.WriteLine(total);

       // textWriter.Flush();
        //textWriter.Close();
    }
}
