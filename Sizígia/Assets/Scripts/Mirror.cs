using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour {

    public  GameObject destination;
    private GameObject player;
    
    private GameObject gc;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        
        gc = GameObject.Find("GameController");
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (gc.GetComponent<GameController>().playerHitMirror && gc.GetComponent<GameController>().hittedMirror == this.gameObject)
            {
                
                player.transform.position = destination.transform.position;

                ChangeDimension();
            }
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            gc.GetComponent<GameController>().playerHitMirror = true;
            gc.GetComponent<GameController>().hittedMirror = this.gameObject;
        }
        else
        {
            gc.GetComponent<GameController>().playerHitMirror = false;
            gc.GetComponent<GameController>().hittedMirror = null;
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        gc.GetComponent<GameController>().playerHitMirror = false;
    }

    private void ChangeDimension()
    {
        if (Globals.currentDimension == "Normal")
        {
            Globals.currentDimension = "Reflection";

            RenderSettings.skybox.SetFloat("_Exposure", -1);

        }
        else
        {
            Globals.currentDimension = "Normal";
            //RenderSettings.skybox = gc.GetComponent<GameController>().skyboxNormal;

            RenderSettings.skybox.SetFloat("_Exposure", 1);
        }

        

    }

}
