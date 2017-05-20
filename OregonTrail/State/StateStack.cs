using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OregonTrail.State
{
    public class StateStack
    {
        private List<IGameState> stack;

        public StateStack()
        {
            stack = new List<IGameState>();
        }

        public void Push(IGameState gameState)
        {
            stack.Add(gameState);
        }

        public void Pop()
        {
            if (stack.Count > 0)
            {
                stack.RemoveAt(stack.Count - 1);
            }
        }

        public void RunState()
        {
            stack[stack.Count - 1].Run();
        }
    }
}
