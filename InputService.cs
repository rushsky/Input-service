using UnityEngine;

namespace CodeBase.Services
{
    public abstract class InputService : IInputService
    {
        protected const string Horizontal = "Horizontal";
        protected const string Vertical = "Vertical";
        private const string Button = "Fire";
        public abstract Vector2 axis { get; }

        public bool AttackButtonUp() => 
            SimpleInput.GetButtonUp(Button);

        protected static Vector2 SimpleInputAxis()
        {
            return new Vector2(SimpleInput.GetAxis(Horizontal), SimpleInput.GetAxis(Vertical));
        }
    }
}