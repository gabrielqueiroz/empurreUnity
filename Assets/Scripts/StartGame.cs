using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	
	void Update(){

		if (Input.GetKeyDown(KeyCode.Space)) {
			Application.LoadLevel(1);
		}		

	}

}