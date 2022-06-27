using System;

namespace SolidGameDemo
{
    public class ToWater : IInteractionManager
    {
        public void ApplyInteraction(IGameItem item)
        {
            Console.WriteLine(item.Name + " watered.");
        }
    }
}
