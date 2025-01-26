using Entitas;
using Entitas.CodeGeneration.Attributes;


public class EntityIdComponent : IComponent
{
   [EntityIndex] public int Value;
}
