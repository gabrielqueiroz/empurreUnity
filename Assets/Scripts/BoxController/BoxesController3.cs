using UnityEngine;
using System.Collections;

public class BoxesController3 : MonoBehaviour {

	public GameObject text;
	
	void Start(){
		text.SetActive (false);
	}
	
	IEnumerator NextLevel()
	{
		while (true) {
			text.SetActive(true);
			yield return new WaitForSeconds(5.0f);
			GameManager.CompleteLevel(6);
		}
	}
	
	void OnTriggerEnter(Collider other){
		if (other.name == "Goal") {

			Material goal = Resources.Load("Goal", typeof(Material)) as Material;
			this.GetComponent<Renderer>().material = goal;
			GameManager.addCurrentScore();
			if ( GameManager.getCurrentScore() == 3){
				StartCoroutine (NextLevel());
			}

		}
	}


}