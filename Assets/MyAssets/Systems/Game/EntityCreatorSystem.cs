using System.Numerics;
using Entitas;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class EntityCreatorSystem : IInitializeSystem
{
    private GameContext _context;
    private GameObject _playerPrefab;
    private GameObject[] _pads;

    public EntityCreatorSystem(Contexts contexts, GameObject playerPrefab, GameObject[] pads)
    {
        _context = contexts.game;
        _playerPrefab = playerPrefab;
        _pads = pads;
    }

    public void Initialize()
    {
        CreatePlayer(_playerPrefab);
        CreateCollectibles(_pads);
    }

    private void CreatePlayer(GameObject playerPrefab)
    {
        GameEntity entity = _context.CreateEntity();
        var player = Object.Instantiate(playerPrefab);
        
        entity.AddPosition(Vector3.zero);
        entity.AddView(player);
    }

    private void CreateCollectibles(GameObject[] pads)
    {
        foreach (GameObject pad in pads)
        {
            var entity = _context.CreateEntity();
            entity.AddView(pad);
            entity.isPad = true;
            pad.AddComponent<PadTriggerListener>().Initialize(entity); // I used chatgpt this line 
        }
    }
}
