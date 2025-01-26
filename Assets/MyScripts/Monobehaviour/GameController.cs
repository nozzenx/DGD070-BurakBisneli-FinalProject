using System;
using ECS.Features;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Contexts _contexts;
    private PlayerHealthFeature _playerHealthFeature;

    private void Start()
    {
        _contexts = Contexts.sharedInstance;

        _playerHealthFeature = new PlayerHealthFeature(_contexts);
        
        _playerHealthFeature.Initialize();
    }

    private void Update()
    {
        _playerHealthFeature.Execute();
    }
}
