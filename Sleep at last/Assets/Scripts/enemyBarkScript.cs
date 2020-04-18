using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBarkScript : MonoBehaviour
{
    //barks are dialogue spoken by enemies when chasing the player
    public string[] enemyBarks;

    public int barkNumManager;

    void Start()
    {
        //sizing the bark array, adding dialogue
        enemyBarks = new string[5];
        enemyBarks[0] = "I can smell you.";
        enemyBarks[1] = "You cannot escape!";
        enemyBarks[2] = "Help me, it hurts...";
        enemyBarks[3] = "Precious light.";
        enemyBarks[4] = "Surrender your light to me";
        //extra creepy >:3c
    }

    void Update()
    {
        //this is to ensure all barks are present
        Debug.Log(enemyBarks[0]);
        Debug.Log(enemyBarks[1]);
        Debug.Log(enemyBarks[2]);
        Debug.Log(enemyBarks[3]);
        Debug.Log(enemyBarks[4]);
        showBarkText();
    }

    //can be accessed by enemy/player script to show on canvas
    public void showBarkText()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //replace this if statement by distance between enemy and player
            barkNumManager = Random.Range(0, 4);
            Debug.Log(barkNumManager);
        }

        if(barkNumManager == 0)
        {

        }

        if (barkNumManager == 1)
        {

        }

        if (barkNumManager == 2)
        {

        }

        if (barkNumManager == 3)
        {

        }

        if (barkNumManager == 4)
        {

        }

    }
}
