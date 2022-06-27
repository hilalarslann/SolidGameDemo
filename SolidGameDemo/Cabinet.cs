namespace SolidGameDemo
{
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
}
