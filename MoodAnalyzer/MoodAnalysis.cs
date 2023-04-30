using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalysis
    {
        public string AnalysisMethod(string Message) 
        {
       
                Message.ToLower();
                bool AnalysisData = false;
                AnalysisData = Message.Contains("sad");
                if (AnalysisData==true) 
                {
                    return"Sad";

                }
                else 
                {
                    return"Happy";
                }
        
        }
    }
}
