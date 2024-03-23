using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Can : MonoBehaviour {
    public int hp = 100;
    public int simdikiCan;
    public Slider hpslider;
    


    // Use this for initialization
    void Start () {
        
        

		
	}
    public void hasarAl(int saldırıGücü) {
        simdikiCan = hp - saldırıGücü;
        hp = simdikiCan;
        hpslider.value = simdikiCan;
        
        if (simdikiCan <= 0) {
            Debug.Log("Öldüm Çıktım !");
            Destroy(gameObject);
            

        }
        if (simdikiCan > 0) {
            Debug.Log(simdikiCan +"Canım Kaldı.");
        }
    }
    // Update is called once per frame
	void Update () {
    }
}
