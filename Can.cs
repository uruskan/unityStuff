using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Can : MonoBehaviour {
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
}
