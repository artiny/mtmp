using UnityEngine;
using System.Collections;

public class ControllerBall : MonoBehaviour {

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
	}
}
