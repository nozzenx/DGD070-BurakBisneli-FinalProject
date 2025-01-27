using Entitas;
using UnityEngine;

public class MoveEntitySystem : IExecuteSystem
{
    private IGroup<GameEntity> _group;
    private InputContext _inputContext;
    private float _speed = 10;
    

    public MoveEntitySystem(Contexts contexts)
    {
        _group = contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.Position));
        _inputContext = contexts.ınput;
    }
    
    public void Execute()
    {
        foreach (var entity in _group.GetEntities())
        {
            if (entity.position.Value.x < -23)
                entity.position.Value.x = -23;
            if (entity.position.Value.x > 23)
                entity.position.Value.x = 23;
            if (entity.position.Value.z > 13)
                entity.position.Value.z = 13;
            if (entity.position.Value.z < -13)
                entity.position.Value.z = -13;
            
            if(!UIManager.Instance.pauseGame)
                entity.ReplacePosition(entity.position.Value + new Vector3(_inputContext.playerInput.Value.x,0 ,_inputContext.playerInput.Value.y) * Time.deltaTime * _speed);
        }
    }
}
