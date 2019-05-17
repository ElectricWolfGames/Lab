using System;

namespace Examples.BasicCode
{
    public class PlayerControl
    {
        private Action _action;

        public PlayerControl()
        {
            _action = Init;
        }

        public void Update()
        {
            _action.Invoke();
        }

        private void Init()
        {
            Console.WriteLine("Player Init");
            _action = Walk;
        }

        private void Walk()
        {
            Console.WriteLine("Player Walk");
        }
    }
}
