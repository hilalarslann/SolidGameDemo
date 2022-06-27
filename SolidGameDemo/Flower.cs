namespace SolidGameDemo
{
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
}
