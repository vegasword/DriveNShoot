using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agressive_NPC_Routine : MonoBehaviour
{
  [SerializeField] private NavMeshAgent navMeshAgent;
  private GameObject player;
  private GameObject target;
  private GameObject[] allTargets;
  
  [SerializeField] float sectorSize = 50;
  [SerializeField] float triggerDistance = 20;
  [SerializeField,Range(0,70)] float aimSpreadAngle = 30;

  private float lastShotTime;
  [SerializeField] private float shootDelay = 1;

  void Start()
  {
    navMeshAgent = GetComponent<NavMeshAgent>();
    player = GameObject.FindGameObjectWithTag("Player");
    allTargets = GameObject.FindGameObjectsWithTag("AgressiveTarget");
    List<GameObject> targetsWithinDistance = new();

    foreach (GameObject _target in allTargets)
      if (Vector3.Distance(transform.position, _target.transform.position) < sectorSize)
        targetsWithinDistance.Add(_target);

    allTargets = targetsWithinDistance.ToArray();
    target = allTargets[Random.Range(0, allTargets.Length)];
    shootDelay = Time.time;
  }

  void Update()
  {
    navMeshAgent.speed = 2f;

    float toPlayerDistance = 
      Vector3.Distance(transform.position , player.transform.position);
      
    if (toPlayerDistance <= triggerDistance)
    {
      target = player;
    }
    
    if (target != null)
    {
      float toTargetDistance =
        Vector3.Distance(transform.position , target.transform.position);

      if (target == player)
      {
        navMeshAgent.speed = 5f;

        if (toTargetDistance >= 2 * triggerDistance)
          target = allTargets[Random.Range(0, allTargets.Length)];
        
        if (Time.time - lastShotTime >= shootDelay)
        {
          shoot();
          lastShotTime = Time.time;
        }
      }
      else if (toTargetDistance <= 0.5f)
      {
        target = allTargets[Random.Range(0, allTargets.Length)];
      }

      navMeshAgent.destination = target.transform.position;
    }
  }

  private void shoot()
  {
    float randomAngle = Random.Range(-aimSpreadAngle, aimSpreadAngle);
    Vector3 randomDirection =
      Quaternion.Euler(0, randomAngle, 0) * transform.TransformDirection(Vector3.forward);

    if (Physics.Raycast(transform.position, randomDirection, out RaycastHit hit, 20f))
    {
      if (hit.transform.tag == "Player")
      {
        Debug.Log("touché");
      }
    }
    else
    {
      Debug.Log("G raté");
    }
  }
}

