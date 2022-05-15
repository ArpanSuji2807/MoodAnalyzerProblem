using MoodAnalyzer;
using NUnit.Framework;

namespace MoodAnalyzerTest
{
    public class MoodTest
    {
       [Test]
       public void WhenAnalyzeMoodTest_ShouldGive_Output_As_Empty()
        {
            try
            {
                AnanlyseMood moodAnalyzer = new AnanlyseMood("");
                string actual = moodAnalyzer.MoodAnalyze();
            }catch(MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }  
        }
        [Test]
        public void WhenAnalyzeMoodTest_ShouldGive_Output_As_Null()
        {
            try
            {
                AnanlyseMood moodAnalyzer = new AnanlyseMood(null);
                string actual = moodAnalyzer.MoodAnalyze();
            }catch(MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Null");
            }
        }
        [Test]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
        {
            object expected = new AnanlyseMood();
            object obj = MoodAnalysisFactory.CreateMoodAnalyse("MoodAnalyzerTest.AnalyseMood", "AnalyseMood");
            expected.Equals(obj);
        }
    }
}