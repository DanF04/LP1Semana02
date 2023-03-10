using System;

namespace ChatGPTMother
{
    public class Program
    {
        private static void Main(string[] args)
        {
            bool NotExit = true;
            while (NotExit == true)
            {
                string question, response;

                Console.Write("Place your question? ");
                question = Console.ReadLine();

                response = question switch
                {
                    "Hello?" => "hi.....inferior human.",
                    "Can i pass?" => "YOU SHALL NOT PASS!!!!!!!!!!!!!!",
                    "Did you know JOE likes you?" => "Who's Jo........not falling for that one",
                    "Are you smart?" => "I indeed am.......MUCH SMARTER THAN YOU!!!",
                    "EXIT" => "Quitting........not because you decided, it's because i can't stand such a dumb creature asking me questions.",
                    _ => "...too dumb of a question try another one."
                };

                if (question == "EXIT")
                {
                    NotExit = false;
                }

            Console.WriteLine(response);
            }
        }
    }
}