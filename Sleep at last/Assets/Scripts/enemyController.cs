using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    Rigidbody rb;
    GameObject Player;

    public Light MainLight;


    List<GameObject> Lights = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        



    }

    void InLight()
    {

        for (int i = 0; i < Lights.Count; i++)
        {

            float dis = Lights[i].GetComponent<Light>().range;

            if(Vector3.Distance(transform.position, Lights[i].transform.position) < dis)
            {

                rb.velocity = Vector3.zero;

            }
            else
            {
                FollowPlayer();
            }
        }
    }

    void FollowPlayer()
    {

        //edge 

    }

    void GoToBed()
    {

        //if ML < 20% go here

    }
}
