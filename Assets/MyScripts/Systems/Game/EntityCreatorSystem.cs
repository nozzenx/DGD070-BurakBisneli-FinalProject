using Entitas;
using UnityEngine;

public class EntityCreatorSystem : IInitializeSystem
{
    private GameContext _context;

    public EntityCreatorSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Initialize()
    {
        CreateEntity(0);
        CreateEntity(1);
        CreateEntity(2);
    }

    private void CreateEntity(int moverFlag)
    {
        GameEntity entity = _context.CreateEntity();
        entity.AddPosition(Vector3.zero);
        
        entity.AddEntityId(moverFlag < 2 ? 0 : 1);
        
        if(moverFlag == 0)
            entity.AddSpeed(Vector3.right);
        if(moverFlag == 1)
            entity.AddSpeed(Vector3.left);
        if (moverFlag == 2)
        {
            entity.AddSpeed(Vector3.up);
            entity.AddSpeed(Vector3.right);
        }
       
    }
}
