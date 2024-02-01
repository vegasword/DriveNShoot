using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab_NPC;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(prefab_NPC, this.transform.position, Quaternion.identity);
        }
    }
}
