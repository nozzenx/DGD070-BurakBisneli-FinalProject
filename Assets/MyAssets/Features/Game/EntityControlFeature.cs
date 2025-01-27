using UnityEngine;
using Entitas;

public class EntityControlFeature : Feature
{
    private Contexts _contexts;
    private GameObject _playerPrefab;
    private GameObject[] _pads;

    public EntityControlFeature(Contexts contexts, GameObject playerPrefab, GameObject[] pads)
    {
        _contexts = contexts;
        _playerPrefab = playerPrefab;
        _pads = pads;

        Add(new EntityCreatorSystem(contexts, _playerPrefab, _pads));
        Add(new PadControlSystem(contexts));
    }

    public sealed override Systems Add(ISystem system)
    {
        return base.Add(system);
    }
}
