using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour {
    //private GameObject item;
    public GameObject tempParent;
    public GameObject mGuide;
    private Rigidbody rb;
    private Transform oldParent;
    //public RaycastHit getObject;
    //public float moveRange = 50f;
    // Use this for initialization
    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        oldParent = this.transform.parent;
    }
    void OnMouseDown()
    {
        //var player = mGuide.transform.parent;
        //var uzaklik = Vector3.Distance(this.transform.position,player.transform.position);
        //mGuide.transform.localPosition = new Vector3(mGuide.transform.localPosition.x, mGuide.transform.localPosition.y,uzaklik);
        rb.useGravity = false;
        rb.isKinematic = true;
        this.transform.position = mGuide.transform.position;
        this.transform.rotation = this.transform.localRotation; //Identity daha iyi olabilir.
        this.transform.parent = mGuide.transform;
    }
    void OnMouseUp()
    {
        var rot = this.transform.rotation;
        rb.useGravity = true;
        rb.isKinematic = false;
        /*Alttaki kod ne olursa olsun düz düşmesini sağlıyor */
        this.transform.position = mGuide.transform.position;
        this.transform.rotation = new Quaternion(0,rot.y,0,rot.w);
        this.transform.parent = oldParent;
    }
}
