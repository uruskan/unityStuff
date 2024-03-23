using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private GameObject player;
    private Transform playerpos;
    private Transform playertarget;
    private float enemy_donme;
    private float enemy_hiz = 10.0f;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerpos = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vectorToTarget = playerpos.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x)  * Mathf.Rad2Deg - 90;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        enemy_donme = Random.Range(8,16);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * enemy_donme);
        if ((player.transform.position - gameObject.transform.position).magnitude > 5)
        {
            //Vector2 velocity = new Vector2((transform.position.x - player.transform.position.x) * enemy_hiz * Time.deltaTime, (transform.position.y - player.transform.position.y) * enemy_hiz * Time.deltaTime);
            //gameObject.GetComponent<Rigidbody2D>().velocity = -velocity; //Playeri adam gibi hem x hemde y ekseninde takip etmesi için.
            Vector2 velocity = new Vector2((player.transform.position.x - gameObject.transform.position.x) * enemy_hiz * Time.deltaTime, (player.transform.position.y - gameObject.transform.position.y) * enemy_hiz * Time.deltaTime);
            gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
        }
    }
}
