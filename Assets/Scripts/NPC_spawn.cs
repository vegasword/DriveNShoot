using UnityEngine;

public class NPC_Spawn : MonoBehaviour
{
  [SerializeField] private GameObject npc;
  [SerializeField] private Vector2 minLocalBound; 
  [SerializeField] private Vector2 maxLocalBound; 

  void Awake()
  {
    GameObject[] targets = GameObject.FindGameObjectsWithTag("Target");
    foreach (GameObject target in targets)
    {
      float x = Random.Range(target.transform.position.x + minLocalBound.x, target.transform.position.z + maxLocalBound.x);
      float z = Random.Range(target.transform.position.z + minLocalBound.y, target.transform.position.z + maxLocalBound.y); 
      Instantiate(npc, new Vector3(x, 1, z), Quaternion.identity);
    }
  }
}
