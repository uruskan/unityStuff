using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Saldiri : MonoBehaviour
{

    public int saldırıGücü = 200;
    public Can can;
    public float menzil = 125.0f;
    public float saldırıAraligi = 1.2f;
    private float beklemesuresi;
    public GameObject Enemy_Namlu;

    public Transform Enemy_Namlu_pos;
    public float mermi_hizi = 220f;
    public GameObject watershot_prefab_ters;
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
        //RaycastHit2D hit;
        //hit = Physics2D.Raycast(Enemy_Namlu_pos.transform.position, Vector2.up, menzil);
        //Debug.DrawRay(Enemy_Namlu_pos.transform.position, Vector2.up, Color.red);
        if (Input.GetButton("Fire2"))
        {
            if (beklemesuresi <= 0)
            {
                ates();
                beklemesuresi = beklemesuresi + saldırıAraligi;
            }
        }
    }
    public void ates()
    {
        var bullet = (GameObject)Instantiate(
         watershot_prefab_ters,
         Enemy_Namlu_pos.position,
         watershot_prefab_ters.transform.rotation
         );
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.up * 6;
        Destroy(bullet, 1.2f);
    }
}


