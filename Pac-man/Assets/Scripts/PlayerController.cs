using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    bool coll;
    int Pose;
    public Vector3 a;
    Rigidbody Player;
    Transform Coin;
    // Start is called before the first frame update
    void Start()
    {
        Player = this.GetComponent<Rigidbody>();
        speed = 5;
        coll = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (coll==false) { 

        if (Input.GetAxis("Horizontal") < 0)
        {
            a = Vector3.left;
            // transform.Translate(speed*Time.deltaTime,0,0);

        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            a = Vector3.right;

            //transform.Translate(-speed * Time.deltaTime, 0, 0);

        }
        if (Input.GetAxis("Vertical") < 0)
        {
            a = Vector3.back;
            //   transform.Translate(0, 0, speed * Time.deltaTime);

        }
        if (Input.GetAxis("Vertical") > 0)
        {
            a = Vector3.forward;
            // transform.Translate(0, 0, -speed * Time.deltaTime);


        }
        transform.Translate(a * speed * Time.deltaTime);
        }
        else
        {
            speed = 0;
            if ((Input.GetAxis("Horizontal")) < 0 && (Pose != 1))
            {
                coll = false;
                speed = 5;
                a = Vector3.left;
                
                // transform.Translate(speed*Time.deltaTime,0,0);

            }
            if ((Input.GetAxis("Horizontal")) >0 && (Pose!=2))
            {
                coll = false;
                speed = 5;
                a = Vector3.right;

                //transform.Translate(-speed * Time.deltaTime, 0, 0);

            }
            if ((Input.GetAxis("Vertical")) < 0 && (Pose != 3))
            {
                coll = false;
                speed = 5;
                a = Vector3.back;
                //   transform.Translate(0, 0, speed * Time.deltaTime);

            }
            if ((Input.GetAxis("Vertical")) > 0 && (Pose != 4))
            {
                coll = false;
                speed = 5;
                a = Vector3.forward;
                // transform.Translate(0, 0, -speed * Time.deltaTime);


            }
            transform.Translate(a * speed * Time.deltaTime);
        }
       /* Coin = GameObject.FindGameObjectWithTag("Player").transform;
        if(Coin==null)
        {
            Debug.Log("you win");
        }*/
    }
    private void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            //Application.Quit();
        }
    
        if (a == Vector3.left)
        {
            Pose = 1;

        }
        if (a == Vector3.right)
        {
            Pose = 2;

        }
        if (a == Vector3.back)
        {
            Pose = 3;

        }
        if (a == Vector3.forward)
        {
            Pose = 4;


        }
        if (collision.gameObject.tag == "wall")
        {
            coll = true;
           
        }
    }
   


}
