using OregonTrail.State;

namespace OregonTrail
{
    class Game
    {
        private StateStack stateStack;

        public void Run()
        {
            stateStack.RunState();
        }

        public Game()
        {
            stateStack = new StateStack();
            stateStack.Push(new WelcomeState());
        }
    }
}
