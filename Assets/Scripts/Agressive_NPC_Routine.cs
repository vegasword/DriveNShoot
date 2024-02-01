using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agressive_NPC_Routine : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.AI.NavMeshAgent NavMeshAgent;

    private GameObject Target;

    private GameObject[] AllTargets;
    
    [SerializeField]
    float SectorSize;

    [SerializeField]
    float TriggerDistance;

    private GameObject Player;

    [SerializeField,Range(0,90)]
    float aim;

    private float tempsDernierTir;

    [SerializeField]
    private float delaiEntreLesTirs = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        AllTargets = GameObject.FindGameObjectsWithTag("BadGuysTarget");
        List<GameObject> targetsWithinDistance = new List<GameObject>();

        foreach (GameObject t in AllTargets) {
            float distance = Vector3.Distance(this.transform.position, t.transform.position);

            if (distance < SectorSize) {
                targetsWithinDistance.Add(t);
            }
        }
        AllTargets = targetsWithinDistance.ToArray();
        Target = AllTargets[Random.Range(0, AllTargets.Length)];
        tempsDernierTir = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent.speed = 2f;
        if (Vector3.Distance(this.transform.position , Player.transform.position) <= TriggerDistance)
        {
            Target = Player;
        }
        if (Target == Player)
        {
            NavMeshAgent.speed = 5f;
            if (Vector3.Distance(this.transform.position , Target.transform.position) >= 2 * TriggerDistance)
            {
                Target = AllTargets[Random.Range(0, AllTargets.Length)];
            }
            if (Time.time - tempsDernierTir >= delaiEntreLesTirs)
            {
                shoot();
                tempsDernierTir = Time.time;
            }
        }
        else if (Target != null && Vector3.Distance(this.transform.position , Target.transform.position) <= 0.5f)
        {
            Target = AllTargets[Random.Range(0, AllTargets.Length)];
        }
        NavMeshAgent.destination = Target.transform.position;
    }
    private void shoot(){
        float randomAngle = Random.Range(-1 * aim, aim);
        Vector3 randomDirection = Quaternion.Euler(0, randomAngle, 0) * transform.TransformDirection(Vector3.forward);

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

