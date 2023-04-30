using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerMSTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        // Refactored with NoParms TestCase1.1
        public void TestCaseMethod1_1NoParms()
        {
            MoodAnalysis analysis = new MoodAnalysis();
            string expected = "Sad";
            analysis.message = "i am in sad mood";
            string actualResult = analysis.AnalysisMethod();
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]

        // Refactored with parms TestCase1.2
        public void TestCaseMethod1_2NoParms()
        {
            MoodAnalysis analysis = new MoodAnalysis();
            string expected = "Happy";
            analysis.message = "i am in any mood";
            string actualResult = analysis.AnalysisMethod();
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]

        // Refactored with parms TestCase1.1
        public void TestCaseMethod1_1()
        {
            MoodAnalysis analysis = new MoodAnalysis("i am in sad mood");
            string expected = "Sad";
            string actualResult=analysis.AnalysisMethod();
            Assert.AreEqual(expected, actualResult);      
        }

        [TestMethod]

        // Refactored with parms TestCase1.2
        public void TestCaseMethod1_2()
        {
            MoodAnalysis analysis = new MoodAnalysis("i am any mood");
            string expected = "Happy";
            string actualResult = analysis.AnalysisMethod();
            Assert.AreEqual(expected, actualResult);
        }
       
    }
}
