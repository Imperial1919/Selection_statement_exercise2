using System;

namespace Selection_statement_exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello hello hello there youngster!, what is Your favorite subject in public day camp-.. public school?");

            string reply = Console.ReadLine();
            
            switch (reply)
            {
                case "History":
                    Console.WriteLine("Oh yes, that is my favorite subject as well. Makes you realize how far our system has decayed-.. advanced since times long... loooong past us.");
                    break;

                case "Math":
                    Console.WriteLine("Ah yes, Math, a headache embodied in a subject for those who rely on memorization or easy to read examples like myself.");
                    break;

                case "Science":
                    Console.WriteLine(".. Ok, I can get behind that, science and physics are quite interesting after all Kiddo. Can lead to a probable sucessful career too.");
                    break;

                case "Art":
                    Console.WriteLine("A admirable favorite subject, I was in art 4 in school, Just don't try to turn it into a career because reality will slap You in the face.. \n With a razor blade.");
                    break;
                case "English":
                    Console.WriteLine(".. Ew.");
                    break;
                default:
                    Console.WriteLine(".. What?");
                    break;
            }

                

        }
    }
}
