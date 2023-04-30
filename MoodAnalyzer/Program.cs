using System;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string m = "I am sad";
            string m1 = "i am in any mood";
            MoodAnalysis analysis = new MoodAnalysis();
            Console.WriteLine(analysis.AnalysisMethod(m));
            Console.WriteLine(analysis.AnalysisMethod(m1));



        }
    }
}
