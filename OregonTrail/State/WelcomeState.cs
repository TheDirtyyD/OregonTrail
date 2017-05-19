using System;
using System.Collections.Generic;
using OregonTrail.Entity;

namespace OregonTrail.State
{
    class WelcomeState : IGameState
    {
        public void Run()
        {
            var answer = Question.Ask("What is your name");
            Console.WriteLine($"Hello {answer}");

            Console.ReadLine();
        }

    }
}
