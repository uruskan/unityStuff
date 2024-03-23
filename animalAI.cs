using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalAI : MonoBehaviour {
    public float distance = 10f;
    private Vector3 cPos; //Current Position
    public float speed = 4.0f;
    private Vector3 targetPos;
    private bool waitformove = false;
    
    void Start()
    {
        
    }
    void Update()
    {
        if (waitformove == false) { 
        cPos = this.transform.position;
        targetPos = new Vector3(cPos.x + Random.Range(-distance /2,distance / 2), cPos.y, cPos.z + Random.Range(-distance / 2, distance / 2));
        print(targetPos);
        transform.LookAt(targetPos);
        waitformove = true;
        }
        if (waitformove)
        {
            Vector3 d = targetPos - transform.position;
            Vector3 movement = d.normalized * speed * Time.deltaTime;
            transform.position += movement;
            if (movement.sqrMagnitude > d.sqrMagnitude)
            {
                // reached the target position
                transform.position = targetPos;
                waitformove = false;
            }
        }

    }      
  }
