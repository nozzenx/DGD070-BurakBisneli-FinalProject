using Entitas;
using System.Collections.Generic;
using UnityEngine;

public class ProcessInputSystem : ReactiveSystem<InputEntity>
{
    private InputContext _inputContext;
    private Vector2 _finalInput;

    public ProcessInputSystem(Contexts contexts) : base(contexts.ınput)
    {
        _inputContext = contexts.ınput;
    }

    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
    {
        return context.CreateCollector(InputMatcher.AnyOf(InputMatcher.HorizontalInput, InputMatcher.VerticalInput).Added());
    }

    protected override bool Filter(InputEntity entity)
    {
        return true;
    }

    protected override void Execute(List<InputEntity> entities)
    {
        _finalInput = Vector2.zero;

        foreach (InputEntity entity in entities)
        {
            if (entity.hasHorizontalInput)
            {
                _finalInput.x += entity.horizontalInput.Value;
            }

            if (entity.hasVerticalInput)
            {
                _finalInput.y += entity.verticalInput.Value;
            }
        }
        
        _inputContext.ReplacePlayerInput(_finalInput);
    }
}
