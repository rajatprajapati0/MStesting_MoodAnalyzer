using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerMSTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        //TestCase1.1
        public void TestCaseMethod1_1()
        {
            MoodAnalysis analysis = new MoodAnalysis();

            string expected = "Sad";
            string actualResult=analysis.AnalysisMethod("i am in sad mood");
             Assert.AreEqual(expected, actualResult);
      
        }

        [TestMethod]

        //TestCase1.2
        public void TestCaseMethod1_2()
        {
            MoodAnalysis analysis = new MoodAnalysis();

            string expected = "Happy";
            string actualResult = analysis.AnalysisMethod("i am any mood");
            Assert.AreEqual(expected, actualResult);
        }
       
    }
}
