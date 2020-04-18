﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{

    Rigidbody rb;

    GameObject Player;

    public Light MainLight;


    public List<GameObject> Lights = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        InLight();


    }

    void InLight()
    {

        transform.rotation = Quaternion.LookRotation(Player.transform.position);

        for (int i = 0; i < Lights.Count; i++)
        {

            float dis = Lights[i].GetComponent<Light>().range;

            if(Vector3.Distance(transform.position, Lights[i].transform.position) < dis)
            {

                rb.velocity = 0;

               
            }
            else
            {
                
                FollowPlayer();

            }
        }
        
    }


    void FollowPlayer()
    {

        if (Vector3.Distance(transform.position, Player.transform.position) > 1)
        {
            rb.transform.position = Vector3.Lerp(transform.position, Player.transform.position, 0.01f);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }

    }

    void GoToBed()
    {

        //if ML < 20% go here

    }
}
