using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class Ball : MonoBehaviour {
	public Text wintext;


	void OnCollisionEnter(Collision Col){
		if (Col.gameObject.tag == "pelouse") {
			wintext.text = "";
			GetComponent<Rigidbody> ().isKinematic = true;
			transform.position = GameObject.Find ("Depart").GetComponent<Transform> ().position;
			GetComponent<Rigidbody> ().isKinematic = false;
		}

		if(Col.gameObject.tag == "win"){
			Debug.Log ("you won");
			wintext.text = "You Won!";

		}
			
		
	}


	void SetText(){
		wintext.text = "You Won!";
	}


}
