using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mouseLook : MonoBehaviour {
    Vector2 mLook;
    Vector2 smoothV;
    public float hassaslik = 5.0f;
    public float smoothing = 2.0f;
    GameObject character;
	void Start () {
       character = transform.parent.gameObject;//Karakter kameranın parenti olucak.
        
    }
	
	// Update is called once per frame
	void Update () {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"),Input.GetAxisRaw("Mouse Y")); //Mouse yerindeki değişim.
        md = Vector2.Scale(md,new Vector2((hassaslik * smoothing),(hassaslik * smoothing)));//MD = Mouse Delta Hassaslık ve Smoothingle beraber mousedeki değişim
        smoothV.x = Mathf.Lerp(smoothV.x,md.x,1f/ smoothing); //tamamen x eksenin yumuşatmak için
        smoothV.y = Mathf.Lerp(smoothV.y,md.y,1f/smoothing);//y eksenini yumuşatmak için Lerp fonksiyonunu zaten bilmiyorsan bu scripte bakma
        mLook += smoothV; //hesaplarımızın sonucunu bu boş vektöre ekliyoruz.
        mLook.y = Mathf.Clamp(mLook.y,-90f,90f);//Aşağı-Yukarı 90 dereceden fazla dönmememiz gerek.
        transform.localRotation = Quaternion.AngleAxis(-mLook.y,Vector3.right); //Mousenin Düşey(y) hareketi kamerayı Right yani X ekseninde etkileyecek.X ekseni kameranın düşey ekseni oluyor.
        character.transform.localRotation = Quaternion.AngleAxis(mLook.x,character.transform.up);//Mousenin Yatay(x) ekseninde yaptığı hareket, karakterin y ekseninde etkileyecek, y ekseni sağa sola oluyor.
        /*Bu eksenler konusunda Unity oldukça karışık değil ancak anlamak biraz zor,mesela bir nesneyi hareket ettirme modundayken herşey
         adam gibi işte yatay=x,düşey=y,dikey=z ancak iş rotasyona gelince Y ekseni yatay oluyor, X ekseni düşey oluyor falan filan, o yüzden bu scripti
         okurken kafanız karışabilir dikkat edin.
         */
	}
}
