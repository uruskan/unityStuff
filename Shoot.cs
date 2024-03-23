using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject cam;
    RaycastHit hit;
    public float range = 300f;
    public int bulletForce = 10;
    public GameObject bullet;
    List<GameObject> spawnedBullets = new List<GameObject>();
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("Shoot");
            shoot();
        }
	}
    public void shoot()
    {
        var sBullet = Instantiate(bullet,cam.transform.position,cam.transform.rotation);
        spawnedBullets.Add(sBullet);
        var rb = sBullet.GetComponent<Rigidbody>();
        rb.AddForce(cam.transform.forward * bulletForce,ForceMode.Impulse );
    }
}
