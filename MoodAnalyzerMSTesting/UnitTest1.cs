using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerMSTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        // Refactored with NoParms TestCase2.1
        public void TestCaseMethod2_1NoParms()
        {
            MoodAnalysis analysis = new MoodAnalysis();
            string expected = "Happy";
            analysis.message = null;
            string actualResult = analysis.AnalysisMethod();
            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]

        //with parms TestCase2.1
        public void TestCaseMethod2_1()
        {
            MoodAnalysis analysis = new MoodAnalysis(null);
            string expected = "Happy";
            string actualResult=analysis.AnalysisMethod();
            Assert.AreEqual(expected, actualResult);      
        }
 
    }
}
