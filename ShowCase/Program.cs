﻿using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Security.Claims;
using ClassLibraryLeetCode;
using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        
        var str = MergeStringsAlternately.MergeStringsAlternatelySolution("word", "wordword");

        foreach (var st in str)
        {
            Console.WriteLine(st);
            
        }
 
    }
}