using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour {

    public Transform destination;
    private GameObject player;

    private bool playerColliding;

    private GameObject InstText;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        InstText = GameObject.Find("Canvas").transform.Find("MirrorText").gameObject;

        playerColliding = false;

    }
	
	// Update is called once per frame
	void Update () {
        if (playerColliding)
            InstText.SetActive(true);
        else
            InstText.SetActive(false);

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (playerColliding)
            {
                player.transform.position = destination.position;
                ChangeDimension();
            }
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == player)
            playerColliding = true;
        else
            playerColliding = false;
        
    }

    private void OnCollisionExit(Collision collision)
    {
        playerColliding = false;
    }

    private void ChangeDimension()
    {
        if (Globals.currentDimension == "Normal")
            Globals.currentDimension = "Reflection";
        else
            Globals.currentDimension = "Normal";

    }

}
