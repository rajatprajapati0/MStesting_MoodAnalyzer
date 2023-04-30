using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalysis
    {
        public  string message;
        public MoodAnalysis(string Message) 
        {
         this.message = Message;
        }
        public MoodAnalysis()
        {
          
        }
        public string AnalysisMethod() 
        {
           try {
                if (string.IsNullOrEmpty(message))
                {
                  throw new Exception("Happy");

                }
                message.ToLower();
                bool AnalysisData = false;
                AnalysisData = message.Contains("sad");
                if (AnalysisData == true)
                {
                    return "Sad";

                }
                else
                {
                    return "Happy";
                }

                 }
            
            catch(Exception e)
           {
                return e.Message;
           }
               
        
        }
    }
}
