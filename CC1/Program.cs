using System;
using System.Reflection;
using static CC1.Result;

//var result = Result.FindAddTarget(new int[] { 3,3}, 6);
//var result = Result.FindAddTarget(new int[] {3,2,4 }, 6);
var result = FindAddTarget(new int[] { 2, 7, 11, 15 }, 17);

foreach (int i in result) Console.WriteLine(i);



