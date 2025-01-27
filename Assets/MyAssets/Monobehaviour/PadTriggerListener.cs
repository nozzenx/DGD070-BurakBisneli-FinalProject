using System;
using UnityEngine;

public class PadTriggerListener : MonoBehaviour
{
    private GameEntity _entity;

    public void Initialize(GameEntity entity)
    {
        _entity = entity;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_entity.isPad)
        {
            _entity.isPressed = true;
            Debug.Log("Triggered");
        }
    }
}
