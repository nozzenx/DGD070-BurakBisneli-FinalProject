using Entitas;
using UnityEngine;

public class MovePlayerFeature : Feature
{
    private Contexts _contexts;

    public MovePlayerFeature(Contexts contexts)
    {
        _contexts = contexts;

        Add(new SyncPositionSystem(contexts));
        Add(new MoveEntitySystem(contexts));
    }

    public sealed override Systems Add(ISystem system)
    {
        return base.Add(system);
    }
}
