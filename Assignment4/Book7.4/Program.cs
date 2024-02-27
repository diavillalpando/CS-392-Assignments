// See https://aka.ms/new-console-template for more information
using System.IO;
class Program
{
    static void Main()
    {
        string Line;
        string[] correctAnswers = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
        string[] userAnswers = new string [20];
        List<int> incorrectUserAnswers = new List<int>();
        try
        {
            StreamReader sr = new StreamReader(@"C:\Users\karla\source\repos\CS-392-Assignments\Assignment4\Book7.4\answers.txt");
            Line = sr.ReadLine();
            int correct = 0;
            for(int i = 0; i < 20;  i++) 
            {
                if(Line == null)
                {
                    break;
                }
                if (correctAnswers[i] == Line)
                {
                    correct++;
                }
                else
                {
                    incorrectUserAnswers.Add(i+1);
                }
                userAnswers[i] = Line;
                Line = sr.ReadLine();
            }
            sr.Close();
            if (correct >= 15)
            {
                Console.WriteLine("Congratulations! You passed!");
            }
            else
            {
                Console.WriteLine("Unfortunately you did not pass.");
            }
            int wrong = 20 - correct;
            Console.WriteLine("You got: " + correct.ToString() + " correct");
            Console.WriteLine("You got: " + wrong.ToString() + " incorrect");
            string allWrong = string.Join(", ", incorrectUserAnswers);
            Console.WriteLine($"These are all the questions you got wrong: {allWrong}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.ReadLine();
        }
    }
}
