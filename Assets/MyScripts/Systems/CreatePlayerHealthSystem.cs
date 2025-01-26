using ECS.Components;
using Entitas;

namespace ECS.Systems
{
    public class CreatePlayerHealthSystem : IInitializeSystem
    {
        private Contexts _contexts;
        public CreatePlayerHealthSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Initialize()
        {
            GameEntity entity1 = _contexts.game.CreateEntity();
            entity1.AddECSComponentsPlayerHealth(100);
        }
    }
}
