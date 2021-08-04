using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int SpeedRotation;
    private Transform coin;
    // Start is called before the first frame update
    void Start()
    {
        SpeedRotation = 25;
        coin = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        coin.transform.Rotate(SpeedRotation * Time.deltaTime, 0, 0);

    }
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}

