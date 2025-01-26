using Entitas;
using UnityEngine;

namespace ECS.Systems
{
    public class ChangePlayerHealthSystem : IExecuteSystem
    {
        private Contexts _contexts;

        public ChangePlayerHealthSystem(Contexts contexts)
        {
            _contexts = contexts;
        }
        
        public void Execute()
        {
            GameEntity[] entities = _contexts.game.GetEntities(GameMatcher.AllOf(GameMatcher.ECSComponentsPlayerHealth));

            foreach (var entity in entities)
            {
                if(Input.GetKeyDown(KeyCode.D))
                    entity.isECSComponentsPlayerDamaged = true;
                
                if (Input.GetKeyDown(KeyCode.H))
                    entity.isECSComponentsPlayerHealed = true;
                
                
            }

        }
    }
}
