using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class EntityCreatingFeature : Feature
{
    private Contexts _contexts;

    public EntityCreatingFeature(Contexts contexts)
    {
        _contexts = contexts;

        Add(new EntityCreatorSystem(contexts));
    }

    public sealed override Systems Add(ISystem system)
    {
        return base.Add(system);
    }
}
