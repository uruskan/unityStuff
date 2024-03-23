using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ateş : MonoBehaviour {
	public float saldırıHızı = 0.5f;
	public int saldırıGücü = 10;
	GameObject oyuncu;
	bool düsmanMenzil;
	float zamanlayici;
	Can can;
	void Awake(){
		oyuncu = GameObject.FindGameObjectWithTag("oyuncu");
		can = oyuncu.GetComponent<Can>();

	}
    void OnTriggerEnter(Collider other){
		if(other.gameObject == oyuncu){
			düsmanMenzil = true;
		}
	}
	void OnTriggerExit(Collider other){
		if (other.gameObject == oyuncu){
			düsmanMenzil = false;
		}
	}
    void Update () {
		zamanlayici += Time.deltaTime;
		if(zamanlayici >= saldırıHızı){
			Saldır();
		}
		if(can.simdikican <= 0){
			Debug.Log("Öldün by Ateş Script");
		}
	}
    void Saldır(){
		zamanlayici = 0f;
		if (can.simdikican > 0){
			can.HasarAl(saldırıGücü);
		}
	}
	}

