using UnityEngine;
using System.Collections;

public class TextController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject text = GameObject.Find ("Text");
		text.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void activateText(){
		GameObject text = GameObject.Find ("Text");
		text.SetActive(true);
	}
}
