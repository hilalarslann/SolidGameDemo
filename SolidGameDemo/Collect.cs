using System;

namespace SolidGameDemo
{
    public class Collect : IInteractionManager
    {
        public void ApplyInteraction(IGameItem item)
        {
            Console.WriteLine(item.Name + " collected.");
        }
    }
}
