using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalysisException : Exception
    {
        public  enum ExMsg
        {
          Null,
          empty,        
        }
        private readonly ExMsg  type;
        public MoodAnalysisException(ExMsg types,string Msg) :base(Msg)
        {
         this.type=types;
        }
    }
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
           try{
                if (string.IsNullOrEmpty(message))
                {
                  throw new MoodAnalysisException(MoodAnalysisException.ExMsg.empty,"msg Should not be empty or null ");
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
            
           catch(MoodAnalysisException cMsg)
           {
                return cMsg.Message;    
           }
               
        
        }
    }
}
