using Entitas;

public class PlayerInputFeature : Feature
{
    private InputContext _context;

    public PlayerInputFeature(Contexts contexts)
    {
        _context = contexts.ınput;

        Add(new ListenForInputSystem(contexts));
        Add(new ProcessInputSystem(contexts));
    }

   
    
    
    public sealed override Systems Add(ISystem system)
    {
        return base.Add(system);
    }
}
