using System;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Contexts _contexts;
    private PlayerInputFeature _playerInputFeature;
    private EntityCreatingFeature _entityCreatingFeature;

    private void Start()
    {
        _contexts = Contexts.sharedInstance;
        _playerInputFeature = new PlayerInputFeature(_contexts);
        _entityCreatingFeature = new EntityCreatingFeature(_contexts);
        
        
        _playerInputFeature.Initialize();
        _entityCreatingFeature.Initialize();
    }

    private void Update()
    {
        _playerInputFeature.Execute();
        _entityCreatingFeature.Execute();
    }

    private void LateUpdate()
    {
        _playerInputFeature.Cleanup();
        _entityCreatingFeature.Cleanup();
    }
}
