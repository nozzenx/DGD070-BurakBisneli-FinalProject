using System;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Contexts _contexts;
    
    private PlayerInputFeature _playerInputFeature;
    private EntityControlFeature _entityControlFeature;
    private MovePlayerFeature _movePlayerFeature;

    [SerializeField] private GameObject[] pads;
    [SerializeField] private GameObject playerPrefab;

    private void Start()
    {
        _contexts = Contexts.sharedInstance;
        _playerInputFeature = new PlayerInputFeature(_contexts);
        _entityControlFeature = new EntityControlFeature(_contexts, playerPrefab, pads);
        _movePlayerFeature = new MovePlayerFeature(_contexts);
        
        
        
        _playerInputFeature.Initialize();
        _entityControlFeature.Initialize();
        _movePlayerFeature.Initialize();
    }

    private void Update()
    {
        _playerInputFeature.Execute();
        _entityControlFeature.Execute();
        _movePlayerFeature.Execute();
    }

    private void LateUpdate()
    {
        _playerInputFeature.Cleanup();
        _entityControlFeature.Cleanup();
        _movePlayerFeature.Cleanup();
    }
}
