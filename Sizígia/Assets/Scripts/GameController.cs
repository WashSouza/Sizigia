using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    
    public Material skyboxNormal;
    public Material skyboxReflection;

    private Material skyboxCurrent;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        print(RenderSettings.skybox);

        if (Globals.currentDimension == "Normal")
            skyboxCurrent = skyboxNormal;
        else
            skyboxCurrent = skyboxReflection;


        RenderSettings.skybox = skyboxCurrent;
    }
}
