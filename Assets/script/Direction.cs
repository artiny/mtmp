using UnityEngine;
using System.Collections;

public class Direction : MonoBehaviour {
	public int SpeedRotation = 50;
	public int Force = 1000;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = GameObject.Find ("Ball").GetComponent<Transform>().position;

		if (GameObject.Find ("Ball").GetComponent<Rigidbody> ().velocity.magnitude < 0.1) {
			GameObject.Find ("DirectionLine").GetComponent<MeshRenderer> ().enabled = true;
			transform.Rotate (Vector3.up * Input.GetAxis ("Mouse X") * Time.deltaTime * SpeedRotation);
			if (Input.GetButtonDown ("Fire1")) {
				GameObject.Find ("Ball").GetComponent<Rigidbody> ().AddForce (transform.TransformDirection (Vector3.forward*Force));
			}
		
		}
			
		if (GameObject.Find ("Ball").GetComponent<Rigidbody> ().velocity.magnitude > 0.1) {
			GameObject.Find ("DirectionLine").GetComponent<MeshRenderer> ().enabled = false;
		}
	}
}
