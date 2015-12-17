using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int changeCamera = 1;
	public static int currentScore;
	public static int highScore;

	public static int currentLevel = 0;
	public static int unlockedLevel;

	void start(){
		currentScore = 0;
	}

	public static void addCurrentScore(){
		currentScore++;
	}

	public static int getCurrentScore(){
		return currentScore;
	}

	public static void CompleteLevel(int level){
		currentScore = 0;
		currentLevel = level;
		Application.LoadLevel (currentLevel);

	}
	
	void Update(){
	
		if (Input.GetKeyDown (KeyCode.R)) {
			currentScore = 0;
			Application.LoadLevel(Application.loadedLevel);
		}

		if (Input.GetKeyDown (KeyCode.Space) && Application.loadedLevel == 6) {
			Application.LoadLevel(0);
		}
	}

}