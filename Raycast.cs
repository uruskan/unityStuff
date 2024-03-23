using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;


public class Raycast : MonoBehaviour {
	public float range = 500f;
	public Camera fpsCam;
	public GameObject craft;
	public float saldırıAraligi = 0.2f;
	private float beklemesuresi;
	public RaycastHit hit;
    List<GameObject> spawnedObjects = new List<GameObject>();
	public GameObject gamePanel; //Panelin kendi sınıfı yok holder obje oluşturdum.
	int layerMask = 1 << 0; //Sadece default layerde raycastları görüyor gerisinde görmüyor, normalde böyle yapmak çok aptalca olur.
    public int s = 0;
    
void Start(){
        
    }
	void Update () {
        if (Input.GetKey (KeyCode.E) && beklemesuresi <= 0) {
			shoot ();

		}
		if (Input.GetKey (KeyCode.X)) {
			deleteObjects ();
		}
		if (beklemesuresi > 0) {
			beklemesuresi -= Time.deltaTime; 
		}
        if (Input.GetKeyDown (KeyCode.G)) {
            s++;
            Debug.Log(s);
            if (s == 1) {
                characterController ck = GetComponent<characterController>();
                ck.mouseStat();
                Cursor.lockState = CursorLockMode.Confined;
                gamePanel.SetActive(true);
                Time.timeScale = 0;
                
            }
            else if(s == 2)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                gamePanel.SetActive(false);
                s = 0;
                Time.timeScale = 1;
                //fpc.m_MouseLook.lockCursor = true;
            }
            
           }
        
			}
	public void shoot(){
		
		if (Physics.Raycast (fpsCam.transform.position, fpsCam.transform.forward, out hit, range,layerMask)) {
			Vector3 hitpoint = new Vector3(hit.point.x,hit.point.y,hit.point.z);
			GameObject yeniObje = Instantiate (craft,hitpoint,Quaternion.identity);
			spawnedObjects.Add (yeniObje);
			Debug.Log (hit.transform.name);
			//Instantiate (craft,hitpoint,Quaternion.identity);
			beklemesuresi = beklemesuresi + saldırıAraligi;
			//Debug.Log ("Hitin değdiği nokta : " + hit.point);
			//Debug.Log ("Playerin Bulunduğu Nokta : " + this.transform.position);
			//Debug.Log ("Camera objesinin bulunduğu nokta : " + fpsCam.transform.position);
			}else{
			Debug.Log ("You hit nothing");
			//Debug.DrawRay (transform.position,transform.TransformDirection(0,0,range),Color.red);
		}
			}
	public void deleteObjects(){
        for(int i = 0;i < spawnedObjects.Count;i++){
			Destroy (spawnedObjects [i]);
		}
       
    }
   }

