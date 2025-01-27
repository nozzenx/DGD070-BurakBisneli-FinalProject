using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Unique, Input]
public class PlayerInputComponent : IComponent
{
    public Vector2 Value;
}
