using UnityEngine;
using UnityEngine.InputSystem;

public class Interact : MonoBehaviour
{
    private PlayerInput inputs;
    
    private void Awake()
    {
        
    }

    private void OnEnable()
    {
    }
    
    private void OnDisable()
    {
    }

    private void DoInteract(InputAction.CallbackContext callbackContext)
    {
      Debug.Log("Yaya");
    }
}
