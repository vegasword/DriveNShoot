using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]
public class Pawn : MonoBehaviour
{
  [SerializeField] private float speed = 10;
  [SerializeField] private float gravity = -9.81f;
  [SerializeField] private float rotateRate = 1;
  [SerializeField] private float cameraDistance = 20;
  
  private bool isGamepad;
  private GameControls controls;
  private PlayerInput input;
  private CharacterController controller;

  private bool grounded;
  private Vector2 move;
  private Vector2 aim;
  private Vector2 velocity;
  
  private Vector3 moveDirection;
  private Vector3 aimDirection;
  private Vector3 cameraTarget;
  
  private void Awake()
  {
    controller = GetComponent<CharacterController>();
    controls = new GameControls();
    controls.Enable();
    input = GetComponent<PlayerInput>();
  }
  
  private void onEnable()
  {
    controls.Enable();
  }
  
  private void onDisable()
  {
    controls.Disable();
  }

  public void OnDeviceChanged(PlayerInput playerInput)
  {
    isGamepad = playerInput.currentControlScheme.Equals("Gamepad");
  }
  
  private void Update()
  {
    grounded = controller.isGrounded;
    if (grounded && velocity.y < 0) velocity.y = 0;
    
    move = controls.OnFoot.Move.ReadValue<Vector2>();
    
    moveDirection.Set(move.x, 0, move.y);
    controller.Move(moveDirection * speed * Time.deltaTime);
    velocity.y += gravity * Time.deltaTime;
    controller.Move(velocity * Time.deltaTime);
    
    if (isGamepad)
    {
      aim = controls.OnFoot.Aim.ReadValue<Vector2>();
      aimDirection = Vector3.right * aim.x + Vector3.forward * aim.y;
    }
    else
    {
      aim = controls.OnFoot.AimMouse.ReadValue<Vector2>();
      aimDirection.Set(aim.x - (Screen.width/2), 0, aim.y - (Screen.height/2));
      aimDirection = Vector3.Normalize(aimDirection);
    }    
    
    if (aimDirection.sqrMagnitude > 0)
    {
      Quaternion newRotation = Quaternion.LookRotation(aimDirection, Vector3.up);  
      transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotateRate * Time.deltaTime);
    }

    cameraTarget.Set(transform.position.x, cameraDistance, transform.position.z);
    Camera.main.transform.SetPositionAndRotation(cameraTarget, Quaternion.Euler(90, 0, 0));
  }
}
