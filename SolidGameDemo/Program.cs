using System;
using System.Collections.Generic;

namespace SolidGameDemo
{
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
