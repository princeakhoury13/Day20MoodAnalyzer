using Day20MoodAnalyzer;

namespace AnalyzeMoodTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(MoodAnalysisException))]
        public void Analyze_NullMessage_ThrowsMoodAnalysisException()
        {
            //Arrange
            string message = null;

            //Act
            AnalyzeMood moodAnalyzer = new AnalyzeMood(message);

            
        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalysisException), "Exception Raised: No message was passed to determine user's mood!")]
        public void Analyze_NullMessage_ThrowsMoodAnalysisExceptionWithMessage()
        {
            // Arrange
            string message = null;

            // Act and Assert
            try
            {
                AnalyzeMood moodAnalyzer = new AnalyzeMood(message);
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("Exception Raised: No message was passed to determine user's mood!", ex.Message);
                throw;
            }
        }
    }
}