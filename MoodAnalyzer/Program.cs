using System;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string m1 = null;
            MoodAnalysis analysis1 = new MoodAnalysis(m1);

            Console.WriteLine(analysis1.AnalysisMethod());
            MoodAnalysis analysisNoParams = new MoodAnalysis();
            analysisNoParams.message= m1;
            Console.WriteLine(analysisNoParams.AnalysisMethod()+" no params");

           



        }
    }
}
