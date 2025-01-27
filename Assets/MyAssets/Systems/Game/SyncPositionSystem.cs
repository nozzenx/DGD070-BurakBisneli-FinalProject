using Entitas;
using UnityEngine;

public class SyncPositionSystem : IExecuteSystem
{
    private IGroup<GameEntity> _group;
    
    public SyncPositionSystem(Contexts contexts)
    {
        _group = contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.Position, GameMatcher.View));    
    }
    
    public void Execute()
    {
        foreach (var entity in _group.GetEntities())
        {
            var position = entity.position.Value;
            var gameObject = entity.view.GameObject;
            if(gameObject != null)
                gameObject.transform.position = position;
        }
    }
}
