using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
<<<<<<< HEAD

    GameObject Player;

=======
    Rigidbody rb;
    GameObject Player;

    public Light MainLight;


    List<GameObject> Lights = new List<GameObject>();

>>>>>>> e1037f1e03a347b1ebb079b62d4548ae124c7150
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
<<<<<<< HEAD
=======

        rb = GetComponent<Rigidbody>();
>>>>>>> e1037f1e03a347b1ebb079b62d4548ae124c7150
    }

    // Update is called once per frame
    void Update()
    {
        



    }

    void InLight()
    {

<<<<<<< HEAD
=======
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
>>>>>>> e1037f1e03a347b1ebb079b62d4548ae124c7150
    }

    void FollowPlayer()
    {

<<<<<<< HEAD

=======
        //edge 

    }

    void GoToBed()
    {

        //if ML < 20% go here
>>>>>>> e1037f1e03a347b1ebb079b62d4548ae124c7150

    }
}
