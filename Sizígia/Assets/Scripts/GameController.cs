using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    
    public Material skyboxNormal;
    public Material skyboxReflection;

    private Material skyboxCurrent;

    public bool playerHitMirror;

    public GameObject hittedMirror;

    private GameObject InstText;

    // Use this for initialization
    void Start () {
        
        playerHitMirror = false;

        InstText = GameObject.Find("Canvas").transform.Find("MirrorText").gameObject;

    }
	
	// Update is called once per frame
	void Update () {

        print(Globals.currentDimension);

        if (playerHitMirror)
            InstText.SetActive(true);
        else
            InstText.SetActive(false);
               
    }
}
