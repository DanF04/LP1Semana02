using System;

namespace ChatGPTMother
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string question, response;

            Console.Write("Place your question? ");
            question = Console.ReadLine();

            switch (question)
            {
                case "Hello?":
                    response = "hi.....inferior human.";
                    continue;
                case "Can i pass?":
                    response = "YOU SHALL NOT PASS!!!!!!!!!!!!!!";
                    continue;

                case "EXIT":
                    response = "Quitting........not because you decided, it's because i can stand such a dumb creator asking me questions.";
                    break;
            }

            Console.WriteLine(response);
        }
    }
}