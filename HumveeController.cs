using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumveeController : MonoBehaviour {
    private Rigidbody rb;
    public WheelCollider FR;
    public WheelCollider FL;
    public WheelCollider RR;
    public WheelCollider RL;
    public float steerMax = 20f;
    public float motorMax = 1000f;
    public float brakeMax = 100f;
    private float steer = 0f;
    private float motor = 0f;
    private float brake = 0f;
    private Vector3 ra = new Vector3(1, 0, 0);
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
    void FixedUpdate()
    {

        steer = Mathf.Clamp(Input.GetAxis("Horizontal"), -1, 1);
        motor = Mathf.Clamp(Input.GetAxis("Vertical"), -1, 1);
        //brake = -1 * Mathf.Clamp(Input.GetAxis("Vertical"), -1, 0);
        float torque = motorMax * motor;
        FR.motorTorque = torque;
        FL.motorTorque = torque;
        FR.steerAngle = steerMax * steer;
        FL.steerAngle = steerMax * steer;
        //RL.brakeTorque = brakeMax * brake;
        //RR.brakeTorque = brakeMax * brake;
       
    }
    }
