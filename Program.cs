using System.Security.Cryptography.X509Certificates;

namespace Day20MoodAnalyzer
{
    class Program
    {
        public static void Main(string[] args)
        {
            string message = "I am happy";

            AnalyzeMood(message);
            
        }

        public static void AnalyzeMood(string message)
        {
            string happy = "I am happy";
            string sad = "I am sad";

            if(message == happy)
            {
                Console.WriteLine("Mood: Happy");
            }
            else if(message == sad)
            {
                Console.WriteLine("Mood: Sad");
            }
        }
    }
}