using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Routine : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.AI.NavMeshAgent NavMeshAgent;

    [SerializeField]
    private GameObject Target;

    [SerializeField]
    private GameObject[] AllTargets;

    // Start is called before the first frame update
    void Start()
    {
        FindTarget();
    }

    // Update is called once per frame
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
    void FindTarget(){
        if (Target != null)
            Target.transform.tag = "Target";

        AllTargets = GameObject.FindGameObjectsWithTag("Target");
        Target = AllTargets[Random.Range(0, AllTargets.Length)];
        Target.transform.tag = "Untagged";
        NavMeshAgent.destination = Target.transform.position;
    }
}
