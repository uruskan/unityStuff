using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saldırı : MonoBehaviour
{
    
    public int saldırıGücü = 10;
    public Can can;
    public float menzil = 100.0f;
    public float saldırıAraligi = 2.0f;
    private float beklemesuresi;
    public GameObject Namlu;
    
    public Transform Namlu_pos;
    public float mermi_hizi = 1.0f;
    public GameObject watershot_prefab;
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
        hit = Physics2D.Raycast(Namlu_pos.transform.position, Vector2.up, menzil);
        Debug.DrawRay(Namlu_pos.transform.position, Vector2.up, Color.red);
        if (Input.GetButton("Fire1"))
        {
            if (beklemesuresi <= 0)
            {
                ates();
                beklemesuresi = beklemesuresi + saldırıAraligi;
            }

            if (hit.transform != null && hit.transform.tag == "hedef")
            {
                Debug.Log(hit.collider.name);
                can.hasarAl(saldırıGücü);
                beklemesuresi = beklemesuresi + saldırıAraligi;
               }
        }
    }
        
        public void ates() {
        var bullet = (GameObject)Instantiate(
         watershot_prefab,
         Namlu_pos.position,
         Namlu_pos.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.up * 6;
        Destroy(bullet, 1.2f);
    }
}
    

