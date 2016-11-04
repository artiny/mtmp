using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {


	void OnCollisionEnter(Collision Col){
		if (Col.gameObject.tag == "pelouse") {
			GetComponent<Rigidbody> ().isKinematic = true;
			transform.position = GameObject.Find ("Depart").GetComponent<Transform> ().position;
			GetComponent<Rigidbody> ().isKinematic = false;
		}

		if(Col.gameObject.tag == "win"){
			Debug.Log ("nyertel");
		}
			
		
	}

}
