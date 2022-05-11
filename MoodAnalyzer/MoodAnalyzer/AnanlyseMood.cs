namespace MoodAnalyzer
{
    public class AnanlyseMood
    {
        string message;
        public AnanlyseMood(string message)
        {
            this .message = message;
        }
        public string MoodAnalyze()
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "Sad";
                }
                return "Happy";
            }catch(Exception)
            {
                return "Happy";
            }
        }
    }
}