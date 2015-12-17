using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	public Camera cam1;
	public Camera cam2;
	private int statusCamera=1;


	// Use this for initialization
	void Start () {
		offset = transform.position;
		cam1.enabled=true;
		cam2.enabled=false;
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.C)) {
			if(statusCamera==1){
				cam1.enabled=false;
				cam2.enabled=true;
				statusCamera=2;
			} else {
				cam1.enabled=true;
				cam2.enabled=false;
				statusCamera=1;
			}
		}
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
