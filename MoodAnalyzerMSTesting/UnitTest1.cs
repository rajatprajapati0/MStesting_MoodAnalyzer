using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerMSTesting
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]

        // TestCase3.1
        public void TestCaseMethod3_1NoParms()
        {
            try
            {
                string message = "";
                MoodAnalysis analysis = new MoodAnalysis(message);
                string mood = analysis.AnalysisMethod();

            }
            catch(MoodAnalysisException e)
            {
                Assert.AreEqual("msg Should not be empty or null",e.Message);
            };

        }

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
            string expected = null;
            string actualResult=analysis.AnalysisMethod();
            Assert.AreEqual(expected, actualResult);      
        }
 
    }
}
