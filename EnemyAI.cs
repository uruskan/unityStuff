using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
    public float fpstargetdistance; //hedefe ne kadar uzak
    public float enemylookdistance; //ne kadar uzaktan görecek
    public float attackdistance; //ne kadar menzili var
    public float enemymovementspeed;
    public float damping;
    public Transform fpstarget;
    Rigidbody rb;
    //Renderer rend;
	// Use this for initialization
	void Start () {
        //rend = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        fpstargetdistance = Vector3.Distance(fpstarget.position,transform.position); //bu distance bulma fonksiyonu bunu unutma.
        if (fpstargetdistance < enemylookdistance )
        {
            //rend.material.color = Color.yellow;
            lookAtPlayer();
            //print("Look at the player please");
        } 
        if (fpstargetdistance < attackdistance)
        {
            attackPlease();
            //Debug.Log("Attack");
        }
    }
    public void lookAtPlayer()
    {
        Quaternion rotation = Quaternion.LookRotation(fpstarget.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation,rotation,Time.deltaTime * damping);
    }
    public void attackPlease()
    {
        //Debug.Log("Moving");
        rb.AddForce(transform.forward * enemymovementspeed);
        //rb.velocity = (transform.forward * enemymovementspeed);
    }
}
