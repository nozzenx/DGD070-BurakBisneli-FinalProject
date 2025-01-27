using Entitas;
using UnityEngine;

public class PadControlSystem : ReactiveSystem<GameEntity>  // I used some chatgpt while doing this reactive system. :(
{
    private readonly IGroup<GameEntity> _padGroup;

    public PadControlSystem(Contexts contexts) : base(contexts.game)
    {
        _padGroup = contexts.game.GetGroup(GameMatcher.Pad);
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Pressed.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.isPressed && entity.hasView;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities)
    {
        foreach (var entity in entities)
        {
            Object.Destroy(entity.view.GameObject);

            entity.Destroy();

            if (_padGroup.count == 0)
            {
                Debug.Log("Game Ended");
                UIManager.Instance.GameOver();
            }
        }
    }
}