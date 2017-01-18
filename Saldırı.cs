using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saldırı : MonoBehaviour
{
    public GameObject Silah;
    public int saldırıGücü = 10;
    public Can can;
    public float menzil = 100.0f;
    public float saldırıAraligi = 0.25f;
    private float beklemesuresi;
    // Use this for initialization
    void Start()
    {
        can = can.GetComponent<Can>();
        beklemesuresi = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (beklemesuresi > 0)
        {
            beklemesuresi -= Time.deltaTime;
        }
        RaycastHit2D hit;
        hit = Physics2D.Raycast(transform.position, Vector2.right, menzil);
        Debug.DrawRay(transform.position, Vector2.right, Color.red);
        if (Input.GetButton("Fire1"))
        {
            if (beklemesuresi <= 0)
            {
                if (hit != null && hit.collider.tag == "hedef")
                {
                    Debug.Log(hit.collider.name);
                    can.hasarAl(saldırıGücü);
                    beklemesuresi = beklemesuresi + saldırıAraligi;
                }
            }
        }
    }
}
    

