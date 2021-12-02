using System;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        private string Message;
        public string AnalyzeMood(string message)
        {
            try
            {
                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (Exception)
            {
                return "HAPPY";
            }
        }
    }
}