using System;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string m1 = "I am sad";
            string m2 = "i am in any mood";
            MoodAnalysis analysis1 = new MoodAnalysis(m1);
            MoodAnalysis analysis2 = new MoodAnalysis(m2);

            Console.WriteLine(analysis1.AnalysisMethod());
            Console.WriteLine(analysis2.AnalysisMethod());
            MoodAnalysis analysisNoParams = new MoodAnalysis();
            analysisNoParams.message= m1;
            Console.WriteLine(analysisNoParams.AnalysisMethod()+" no params");
            analysisNoParams.message = m2;
            Console.WriteLine(analysisNoParams.AnalysisMethod() + " no params");

           



        }
    }
}
