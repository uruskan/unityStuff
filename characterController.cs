using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {
    public float speed = 10f; //Karakter hızı
    public float jPower = 5f; //Zıplama gücü
    Rigidbody rb;
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;//Mouseyi kilitleme
        Cursor.visible = false;//Mouseyi gizleme
        rb = GetComponent<Rigidbody>();
	}
	void Update () {
        var Translation = Input.GetAxis("Vertical") * speed * Time.deltaTime; //Dikey eksendeki değişim w-s (y ekseni değil farkındaysanız ben dikey diyorum z yani)
        var Straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //Yatay eksendeki değişim a-d
        transform.Translate(Straffe,0,Translation); //Aldığımız Axislerden float değer aldık ve hareket vektörümüzü oluşturduk.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jPower,ForceMode.Impulse); //Yukarıya doğru Zıplama Gücü kadar anlık kuvvet uygula.
        }
        if (Input.GetKeyDown(KeyCode.Escape)) //Bu if döngüsü mouseyi serbest/kilitli yapmak için.
        {
            mouseFree();
        }
    }
public void mouseFree()
    {
        //Başka scriptlerden de erişip mouseyi açabilelim diye fonksiyona yazdım
        if(Cursor.lockState == CursorLockMode.None)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
        Cursor.visible = !Cursor.visible;
    }
}
