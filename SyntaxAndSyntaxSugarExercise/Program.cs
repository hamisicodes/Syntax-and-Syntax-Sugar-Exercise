﻿namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than" : $"{answer} is greater than or equal to 9";

            Console.WriteLine(response);
        }
                
    }
}
