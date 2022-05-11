using MoodAnalyzer;
using NUnit.Framework;

namespace MoodAnalyzerTest
{
    public class MoodTest
    {
       [Test]
       public void WhenAnalyzeMoodTest_InputAsNull_ShouldGive_Output_As_Happy()
        {
            AnanlyseMood moodAnalyzer = new AnanlyseMood(null);
            string actual=moodAnalyzer.MoodAnalyze();
            Assert.AreEqual(actual,"Happy");
        }
        [Test]
        public void WhenAnalyzeMoodTest_ShouldGive_Output_As_Sad()
        {
            AnanlyseMood moodAnalyzer = new AnanlyseMood("I am in Sad Mood");
            string actual = moodAnalyzer.MoodAnalyze();
            Assert.AreEqual(actual, "Sad");
        }
    }
}