using System;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        private string Message;
        public string AnalyzeMood(string message)
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
    }
}