using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20MoodAnalyzer
{
    public class AnalyzeMood
    {
        public string message;
        public string happy = "I am happy";
        public string sad = "I am sad";
      

        public AnalyzeMood(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new MoodAnalysisException("Exception Raised: No message was passed to determine user's mood!");
            }
            this.message = message;
        }

        public void Analyze()
        {
            if(this.message == happy)
            {
                Console.WriteLine("Mood: Happy");
            }
            else if(this.message == sad)
            {
                Console.WriteLine("Mood: Sad");
            }
        }

    }
}
