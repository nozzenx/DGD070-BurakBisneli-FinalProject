using Entitas;
using UnityEngine;

public class ListenForInputSystem : IExecuteSystem
{
    private InputContext _context;
    private float _horizontalInput;
    private float _verticalInput;

    public ListenForInputSystem(Contexts contexts)
    {
        _context = contexts.ınput;
    }
    
    public void Execute()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        
        _context.ReplaceHorizontalInput(_horizontalInput);
        _context.ReplaceVerticalInput(_verticalInput);
    }
}
