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

            response = question switch
            {
                "Hello?" => "hi.....inferior human.",
                "Can i pass?" => "YOU SHALL NOT PASS!!!!!!!!!!!!!!",
                "EXIT" => "Quitting........not because you decided, it's because i can stand such a dumb creature asking me questions.",
                _ => "...too dumb try another question."
            };

            Console.WriteLine(response);
        }
    }
}