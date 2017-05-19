using OregonTrail.State;

namespace OregonTrail
{
    class Game
    {
        private IGameState state;

        public void Run()
        {
            state.Run();
        }

        public Game()
        {
            state = new WelcomeState();
        }
    }
}
