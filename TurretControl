using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ateş : MonoBehaviour {
public GameObject mermipf;
public GameObject n1;
public GameObject n2;
public GameObject n3;
public GameObject n4;
//public AudioSource ses;
public float attackrate = 1.0f;
public float cooldown;
public int mermihizi = 3000;
// Use this for initialization
void Start () {
cooldown = 0.0f;
//AudioSource ses = this.GetComponent<AudioSource>();
}

// Update is called once per frame
void Update () {
cooldown -= Time.deltaTime;
if (Input.GetKey(KeyCode.Space))
{
if (cooldown <= 0)
{
ates();
//ses.Play();
cooldown += attackrate;
}
}
}
public void ates()
{
var mermi = (GameObject)Instantiate(
mermipf,
n1.transform.position,
n1.transform.rotation
) as GameObject;
mermi.GetComponent<Rigidbody>().AddForce(Vector3.forward * mermihizi);
var mermi2 = (GameObject)Instantiate(
mermipf,
n2.transform.position,
n2.transform.rotation
) as GameObject;
mermi2.GetComponent<Rigidbody>().AddForce(Vector3.forward * mermihizi);
var mermi3 = (GameObject)Instantiate(
mermipf,
n3.transform.position,
n3.transform.rotation
) as GameObject;
mermi3.GetComponent<Rigidbody>().AddForce(Vector3.forward * mermihizi);
var mermi4 = (GameObject)Instantiate(
mermipf,
n4.transform.position,
n4.transform.rotation
) as GameObject;
mermi4.GetComponent<Rigidbody>().AddForce(Vector3.forward * mermihizi);

}
}
