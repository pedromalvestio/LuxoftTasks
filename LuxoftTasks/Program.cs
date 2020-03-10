using LuxoftTasks.FirstTask;
using LuxoftTasks.SecondTask;
using System;

namespace LuxoftTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Task Solution:");
            Console.WriteLine(new MaxSum().FindSum(new int[] { 1, 2, 3, 1 }).ToString());
            Console.WriteLine(new MaxSum().FindSum(new int[] { 3, 4, 1, 1 }).ToString());
            Console.WriteLine(new MaxSum().FindSum(new int[] { 2, 7, 9, 3, 1 }).ToString());
            Console.WriteLine(new MaxSum().FindSum(new int[] { 5, 1, 2, 5 }).ToString());
            
            Console.WriteLine("");
            Console.WriteLine("Second Task Solution");

            char[][] firstExample =
            {
                new char[] {'1','0','1'},
                new char[] {'0','1','0'},
                new char[] {'1','0','1'}
            };

            Console.WriteLine(new DeadPixels().CountGroups(firstExample).ToString());

            char[][] secondExample =
            {
                new char[] {'1','1','1'},
                new char[] {'1','0','0'},
                new char[] {'1','0','1'}
            };
            Console.WriteLine(new DeadPixels().CountGroups(secondExample).ToString());
            Console.WriteLine("");
            Console.WriteLine("Third Task Solution:");
            Console.WriteLine("First Task Time Complexity: O(n)");
            Console.WriteLine("First Task Spatial Complexity: O(s) ");
            Console.WriteLine("Second Task Time Complexity: O(n²)");
            Console.WriteLine("Second Task Spatial Complexity: O(s²)");

            Console.ReadLine();
           
        }
    }
}
