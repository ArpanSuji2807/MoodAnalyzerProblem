namespace MoodAnalyzer
{
    public class AnanlyseMood
    {
        string message;

        public AnanlyseMood()
        { }
        public AnanlyseMood(string message)
        {
            this .message = message;
        }
        public string MoodAnalyze()
        {
            try
            {
                if (message == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD, "Message is Null");
                }
                if (message.Equals(""))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "Message is Empty");

                }
                if (message.ToLower().Contains("sad"))
                {
                    return "Sad";
                }
                return "Happy";
            }catch(MoodAnalyserException ex)
            {
                return ex.Message;
            }
        }
    }
}