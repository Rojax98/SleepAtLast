using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{

    GameObject Player;

    public Light MainLight;


    List<GameObject> Lights = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        



    }

    void InLight()
    {




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
