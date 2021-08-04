using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySponer : MonoBehaviour
{
    public Transform[] positions;
    // public GameObject enemy; ou
     
    // Start is called before the first frame update
    void Start()
    {
        GameObject enemy = Resources.Load<GameObject>("Prefabs/enemy");
        Instantiate(enemy, positions[Random.Range(0,positions.Length)].position,Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
