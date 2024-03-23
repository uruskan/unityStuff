using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RpgciKontrol : MonoBehaviour
{
    public GameObject EngineRight;
    public GameObject EngineLeft;
    public GameObject EngineUpleft;
    public GameObject EngineUpright;
    public int güc = 50;
    GameObject jet;
    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        jet = GameObject.FindGameObjectWithTag("jet");
        rb = jet.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * güc);
            EngineUpleft.SetActive(true);
            EngineUpright.SetActive(true);
        }
        else
        {
            EngineUpleft.SetActive(false);
            EngineUpright.SetActive(false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * güc);
            EngineLeft.SetActive(true);
        }
        else
        {
            EngineLeft.SetActive(false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.up * güc);
            EngineUpleft.SetActive(false);
            EngineUpright.SetActive(false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * güc);
            EngineRight.SetActive(true);
        }
        else {
            EngineRight.SetActive(false);
        }
    
    }
}