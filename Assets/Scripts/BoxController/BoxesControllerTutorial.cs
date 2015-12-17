using UnityEngine;
using System.Collections;

public class BoxesControllerTutorial : MonoBehaviour {

	
	void Start(){
	}

	IEnumerator NextLevel()
	{
		while (true) {
			yield return new WaitForSeconds(5.0f);
			GameManager.CompleteLevel(2);
		}
	}
	
	void OnTriggerEnter(Collider other){
		if (other.name == "Goal") {

			Material goal = Resources.Load("Goal", typeof(Material)) as Material;
			this.GetComponent<Renderer>().material = goal;
			StartCoroutine (NextLevel());
	
		}
	}


}