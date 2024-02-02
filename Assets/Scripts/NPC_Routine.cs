using UnityEngine;

public class NPC_Routine : MonoBehaviour
{
  [SerializeField] private UnityEngine.AI.NavMeshAgent NavMeshAgent;
  [SerializeField] private GameObject Target;
  [SerializeField] private GameObject[] AllTargets;

  void Start()
  {
    FindTarget();
  }

  void Update()
  {
    if (Target != null)
    {
      if (Vector3.Distance(this.transform.position , Target.transform.position) <= 0.5f)
      {
        FindTarget();
      }
    }
  }
  
  void FindTarget()
  {
    AllTargets = GameObject.FindGameObjectsWithTag("Target");
    Target = AllTargets[Random.Range(0, AllTargets.Length)];
    NavMeshAgent.destination = Target.transform.position;
  }
}
