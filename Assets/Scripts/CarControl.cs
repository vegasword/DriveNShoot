using UnityEngine;
using UnityEngine.InputSystem;

public class CarControl : MonoBehaviour
{  
  public bool engineOn;
  public float turn;
  public float accelerate;
  public float brake;
  
  public GameObject inside;
  public GameObject outside;
  
  public float motorTorque = 2000;
  public float brakeTorque = 2000;
  public float maxSpeed = 20;
  public float steeringRange = 30;
  public float steeringRangeAtMaxSpeed = 10;
  public float centreOfGravityOffset = -1f;

  private WheelControl[] wheels;
  private Rigidbody rigidBody;
  
  private void Start()
  {
    rigidBody = GetComponent<Rigidbody>();
    rigidBody.centerOfMass += Vector3.up * centreOfGravityOffset;
    wheels = GetComponentsInChildren<WheelControl>();
  }

  private void Update()
  {    
    if (engineOn)
    {      
      float forwardSpeed = Vector3.Dot(transform.forward, rigidBody.velocity);
      float speedFactor = Mathf.InverseLerp(0, maxSpeed, forwardSpeed);
      float currentMotorTorque = Mathf.Lerp(motorTorque, 0, speedFactor);
      float currentSteerRange = Mathf.Lerp(steeringRange, steeringRangeAtMaxSpeed, speedFactor);
      bool isAccelerating = Mathf.Sign(accelerate) == Mathf.Sign(forwardSpeed);
      
      foreach (var wheel in wheels)
      {
        if (wheel.steerable)
          wheel.WheelCollider.steerAngle = turn * currentSteerRange;
        
        if (isAccelerating)
        {
          if (wheel.motorized)
            wheel.WheelCollider.motorTorque = 
              (brake != 0 ? -brake : accelerate) * currentMotorTorque;
          wheel.WheelCollider.brakeTorque = 0;
        }
        else
        {
          wheel.WheelCollider.brakeTorque = Mathf.Abs(brake) * brakeTorque;
          wheel.WheelCollider.motorTorque = 0;
        }
      }
    }
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Player")
    {
      Pawn p = other.GetComponent<Pawn>();
      if (!p.driving) p.vehicle = GetComponent<CarControl>();
    }
  }
  
  private void OnTriggerExit(Collider other)
  {
    if (other.tag == "Player")
    {
      Pawn p = other.GetComponent<Pawn>();
      if (!p.driving) p.vehicle = null;
    }
  }
}
