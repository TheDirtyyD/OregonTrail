using System;

namespace OregonTrail.Entity
{
    public class Question
    {
        public static string Ask(string questionText)
        {
            Console.WriteLine(questionText);
            return Console.ReadLine();
        }
    }
}
