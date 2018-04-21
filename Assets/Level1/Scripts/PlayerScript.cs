using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	public enum SpecifiedLane{Lane1 = 0,Lane2 = 1,Lane3 = 2,Lane4 = 3,Lane5 = 4,Lane6 = 5,Lane7 = 6,Lane8 = 7,Lane9 = 8,Lane10 = 9,Lane11 = 10,Lane12 = 11,Lane13 = 12,Lane14 = 13,Lane15 = 14,Lane16 = 15}
	public SpecifiedLane lane;
	public KeyCode[] Controls;
	public float Speed;

	Rigidbody RB;
	// Use this for initialization
	void Start () {
		RB = GetComponent<Rigidbody> ();
		Controls [0] = (KeyCode)Enum.Parse (typeof(KeyCode), PlayerPrefs.GetString ("LeftKey" + ((int)lane)));
		Controls [1] = (KeyCode)Enum.Parse (typeof(KeyCode), PlayerPrefs.GetString ("RightKey" + ((int)lane)));
	}
	
	// Update is called once per frame
	void Update () {
		ControlingUpdate ();
	}
	void ControlingUpdate(){
		if (Input.GetKeyDown (Controls [0])) {
			RB.velocity /= 10.0f;
			RB.AddForce (transform.forward*360.0f*Speed);
			RB.AddTorque (new Vector3 (0.0f, -1.6f*Speed, 0.0f));
		}
		if (Input.GetKeyDown (Controls [1])) {
			RB.velocity /= 10.0f;
			RB.AddForce (transform.forward*360.0f*Speed);
			RB.AddTorque (new Vector3 (0.0f, 1.6f*Speed, 0.0f));
		}
	}
}
