using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Can : MonoBehaviour {
<<<<<<< HEAD
	public int normalcan = 100;
	public int simdikican;
	public Slider HPSlider;
	public Image damageImage;
	bool ölüm;
	bool damaged;
	Karakter karakter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Awake() {
        karakter = GetComponent<Karakter>();
		normalcan = simdikican;

	}
	public void HasarAl (int saldırıGücü){
        damaged = true;
		simdikican -= saldırıGücü;
		HPSlider.value = simdikican;
		if (simdikican <= 0 && !ölüm){
			Öldü();
		}
	}
	    void Öldü(){
			ölüm = true;
			Debug.Log("Öldün Çık");
			karakter.enabled = false;
		}
	void Update () {
		
	}
=======
    public int hp = 100;
    public int simdikiCan;
    public Slider hpslider;
    public GameObject rpgci;


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
            rpgci.SetActive(false);

        }
        if (simdikiCan > 0) {
            Debug.Log(simdikiCan +"Canım Kaldı.");
        }
    }
    // Update is called once per frame
	void Update () {
    }
>>>>>>> g3/master
}
