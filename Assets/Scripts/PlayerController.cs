using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public string direction;

	void Update (){

	}

	void OnTriggerEnter(Collider other){

	}

	void FixedUpdate(){

//**	Move function '3D' controller
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rigidbody.AddForce(movement * speed * Time.deltaTime);

	}

}