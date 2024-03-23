using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Control : MonoBehaviour {
    public int turnspeed = 30;
    public GameObject head;
    public GameObject cylinder;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.D))
        {
            cylinder.transform.Rotate(0,0,Time.deltaTime * turnspeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            cylinder.transform.Rotate(0, 0, -Time.deltaTime * turnspeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            head.transform.Rotate(0, -Time.deltaTime * turnspeed,0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            head.transform.Rotate(0,Time.deltaTime * turnspeed, 0);
        }
	}
}
