using ECS.Systems;
using Entitas;

namespace ECS.Features
{
    public class PlayerHealthFeature : Feature
    {
        private Contexts _contexts;

        public PlayerHealthFeature(Contexts contexts)
        {
            _contexts = contexts;
            Add(new CreatePlayerHealthSystem(contexts));
            Add(new CheckPlayerHealthSystem(contexts));
            Add(new ChangePlayerHealthSystem(contexts));
        }

        
        public sealed override Entitas.Systems Add(ISystem system)
        {
            return base.Add(system);
        }
    }
}
