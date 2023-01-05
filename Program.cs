using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";


        // Declare second integer, double, and String variables.
        int ii = 8;
        double dd = 5.3;
        string ss = "provides me a space to practice and build my skills";

        // Read and save an integer, double, and String to your variables.
        Console.ReadLine(i);
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + ii);

        // Print the sum of the double variables on a new line.
        Console.WriteLine(d + dd);

        // Concatenate and print the String variables on a new line

        Console.WriteLine(s + ss);
        // The 's' variable above should be printed first.

    }
}