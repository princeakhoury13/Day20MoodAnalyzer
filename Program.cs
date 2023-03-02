using System.Security.Cryptography.X509Certificates;

namespace Day20MoodAnalyzer
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                AnalyzeMood mood = new AnalyzeMood("");
                mood.Analyze();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}