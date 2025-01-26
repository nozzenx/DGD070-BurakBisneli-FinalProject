using ECS.Components;
using Entitas;
using UnityEngine;

namespace ECS.Systems
{
    public class CheckPlayerHealthSystem : IExecuteSystem
    {
        private Contexts _contexts;

        public CheckPlayerHealthSystem(Contexts contexts)
        {
            _contexts = contexts;
        }
        
        public void Execute()
        {
            GameEntity[] entities = _contexts.game.GetEntities(GameMatcher.AnyOf(GameMatcher.ECSComponentsPlayerHealed, GameMatcher.ECSComponentsPlayerDamaged)); // Getting all entities with player healed or player damaged component

            foreach (var entity in entities)
            {
                
                if (entity.isECSComponentsPlayerDamaged)
                {
                    entity.eCSComponentsPlayerHealth.Value = Mathf.Max(entity.eCSComponentsPlayerHealth.Value -= 10, 0);
                    
                    if (entity.eCSComponentsPlayerHealth.Value <= 0)
                        entity.Destroy();
                    
                    entity.isECSComponentsPlayerDamaged = false;
                    
                }


                if (entity.isECSComponentsPlayerHealed)
                {
                    entity.eCSComponentsPlayerHealth.Value = Mathf.Min(entity.eCSComponentsPlayerHealth.Value += 10, 100);
                    entity.isECSComponentsPlayerHealed = false;
                }
                
            }
        }
    }
}
