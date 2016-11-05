using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Direction : MonoBehaviour {
	
	public int SpeedRotation = 50;
	public int Force = 0;
	public TextMesh TxtForce;
	public Text TxtShot;
	public int Shots = 0;
	float distance = 10;

	// Use this for initialization
	void Start () {
		//pointer
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
		
		//pointer Esc
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;

		}
		
		transform.position = GameObject.Find ("Ball").GetComponent<Transform>().position;

		if (GameObject.Find ("Ball").GetComponent<Rigidbody> ().velocity.magnitude < 0.1) {
			GameObject.Find ("DirectionLine").GetComponent<MeshRenderer> ().enabled = true;
			TxtForce.GetComponent<MeshRenderer> ().enabled = true;

			transform.Rotate (Vector3.up * Input.GetAxis ("Mouse X") * Time.deltaTime * SpeedRotation);
			if (Input.GetButtonDown ("Fire1")) {
				GameObject.Find ("Ball").GetComponent<Rigidbody> ().AddForce (transform.TransformDirection (Vector3.forward*Force));
				Shots += 1;
				TxtShot.text = "Shot : " + Shots;
			}
			if (Input.GetButton ("Fire2")) 
			{
				if (Force < 5010) {
					Force += 10;
				} else
				{
					Force = 0;
				}
			
				TxtForce.text = "" + Force/50 + "%";
			}				
			if (Input.GetMouseButtonDown (2)) 
			{
				Force = 0;
				TxtForce.text = "" + Force/50 + "%";
			}

			if( Input.GetKeyUp( KeyCode.Space ) ){
				Debug.Log( "Space key was released." );
				Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
				Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
				transform.position = objPosition;
		}


		}
			
		if (GameObject.Find ("Ball").GetComponent<Rigidbody> ().velocity.magnitude > 0.1) {
			GameObject.Find ("DirectionLine").GetComponent<MeshRenderer> ().enabled = false;
			TxtForce.GetComponent<MeshRenderer> ().enabled = false;
		}
	}

	public void Perdu(){
		Shots = 0;
		TxtShot.text = "Shot : " + Shots;
		
	}


}
