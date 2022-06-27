using System;
using System.Collections.Generic;

namespace SolidGameDemo
{
    public interface IGameItem
    {
        string Name { get;}
    }

    public interface IInteractable
    {
        void Interact();
    }

    public class Flower : IGameItem, IInteractable
    {
        IInteractionManager interactionManager;
        public string Name { get; set; }
        public Flower(IInteractionManager interactionManager, string name)
        {
            this.interactionManager = interactionManager;
            Name = name;
        }

        public void Interact()
        {
            interactionManager.ApplyInteraction(this);
        }
    }

    public class Cabinet : IGameItem, IInteractable
    {
        private IInteractionManager interactionManager;
        public string Name => "Red cabinet";
        public Cabinet(IInteractionManager interactionManager)
        {
            this.interactionManager = interactionManager;
        }

        public void Interact()
        {
            interactionManager.ApplyInteraction(this);
        }
    }

    public interface IInteractionManager
    {
        void ApplyInteraction(IGameItem item);
    }

    public class ToWater : IInteractionManager
    {
        public void ApplyInteraction(IGameItem item)
        {
            Console.WriteLine(item.Name + " watered.");
        }
    }

    public class Collect : IInteractionManager
    {
        public void ApplyInteraction(IGameItem item)
        {
            Console.WriteLine(item.Name + " collected.");
        }
    }

    class Program
    {
        public static List<IGameItem> items = new List<IGameItem>();
        public static Collect collect = new Collect();
        public static ToWater  toWater = new ToWater();


        static void Main(string[] args)
        {
            items.Add(new Cabinet(collect));
            items.Add(new Flower(toWater, "Yellow flower"));

            EKey();

            Console.ReadLine();
        }

        public static void EKey()
        {
            foreach (var item in items)
            {
                if (item is IInteractable)
                {
                    (item as IInteractable).Interact();
                }
            }
        }
    }
}
