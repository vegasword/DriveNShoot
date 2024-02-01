using UnityEngine;

public class CarControl : MonoBehaviour
{  
  public bool engineOn;
  public float turnInput;
  public float accelerateInput;
  public float brakeInput;
  
  public GameObject inside;
  public GameObject outside;
  
  public float motorTorque = 2000;
  public float brakeTorque = 2000;
  public float maxSpeed = 100;
  public float forwardStiffness = 5;
  public float sidesStiffness = 5;
  public float driftStiffness = 0.5f;
  public float steeringRange = 30;
  public float steeringRangeAtMaxSpeed = 10;
  public float gravityCenterOffset = -1f;

  private WheelControl[] wheels;
  private WheelCollider[] wheelsColliders;
  private Rigidbody rigidBody;
  
  private void Start()
  {
    rigidBody = GetComponent<Rigidbody>();
    rigidBody.centerOfMass += Vector3.up * gravityCenterOffset;

    wheels = GetComponentsInChildren<WheelControl>();
    wheelsColliders = GetComponentsInChildren<WheelCollider>();
    foreach (WheelCollider collider in wheelsColliders)
    {
      WheelFrictionCurve newWfc;
      newWfc = collider.sidewaysFriction;
      newWfc.stiffness = sidesStiffness;
      collider.sidewaysFriction = newWfc; 
      newWfc = collider.forwardFriction;
      newWfc.stiffness = forwardStiffness;
      collider.forwardFriction = newWfc; 
   }
  }

  public void Drift(bool drifting)
  {
    foreach (WheelCollider collider in wheelsColliders)
    {
      WheelFrictionCurve newWfc;
      newWfc = collider.sidewaysFriction;
      newWfc.stiffness = drifting ? 0.5f : 2f;
      collider.sidewaysFriction = newWfc; 
    }
  }

  private void Update()
  {    
    if (engineOn)
    {      
      float forwardSpeed = Vector3.Dot(transform.forward, rigidBody.velocity);
      float speedFactor = Mathf.InverseLerp(0, maxSpeed, forwardSpeed);
      float currentSteerRange = Mathf.Lerp(steeringRange, steeringRangeAtMaxSpeed, speedFactor);
      bool reverse = accelerateInput == 0 && brakeInput > 0;
      
      foreach (var wheel in wheels)
      {
        if (wheel.steerable)
          wheel.WheelCollider.steerAngle = turnInput * currentSteerRange;
        
        if (wheel.motorized)
        {
          if (reverse)
            wheel.WheelCollider.motorTorque = -brakeInput * brakeTorque;
          else
            wheel.WheelCollider.motorTorque = accelerateInput * motorTorque;
        }

        if (!reverse)
          wheel.WheelCollider.brakeTorque = brakeInput * brakeTorque;
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
