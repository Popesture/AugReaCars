using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class freeRoam : MonoBehaviour {
	float newForce = 16f;
	float rotForce = 150f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Translation
		GameObject.FindWithTag ("Model").transform.Translate(0, 0 , -CrossPlatformInputManager.GetAxis("Vertical")* newForce);

		//Rotation
		GameObject.FindWithTag ("Model").transform.Rotate (0, (CrossPlatformInputManager.GetAxis("Horizontal") * Time.deltaTime)*rotForce, 0);
	}
}
