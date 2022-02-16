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
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        List<int> Sonuc = new List<int>();
        List<int> Higher = new List<int>();
        List<int> Lowest = new List<int>();
        List<int> scorestemp = new List<int>();
        int kucuk = 0; 
        int buyuk = 0;
        for(int i= 0; i < scores.Count; i++)
        {
            if (i == 0)
            {
                kucuk = scores[i];
                buyuk = scores[i];
                scorestemp.Add(scores[i]);
                Higher.Add(scores[i]);
                Lowest.Add(scores[i]);
            }
            else
            {
                scorestemp.Add(scores[i]);
                if (buyuk < scores[i])
                {
                    Higher.Add(scores[i]);
                    Higher.Sort();
                    Higher.Reverse();
                    buyuk = Higher[0];
                    
                }
                if(kucuk > scores[i])
                {
                    Lowest.Add(scores[i]);
                    Lowest.Sort();
                    kucuk = Lowest[0];

                }
               
               

            }
          

        }
        Sonuc.Add(Higher.Count - 1);
        Sonuc.Add(Lowest.Count - 1);
        return Sonuc;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        Console.WriteLine(result[0] + " " + result[1]);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
