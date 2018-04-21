using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobbingScript : MonoBehaviour {
	public float bobbleHeight = 0.5f;
	public float bobbleSpeed = 1.0f;


	private float OriginalY;
	private float StartOffset;

	// Use this for initialization
	void Start () {
		OriginalY = transform.position.y;
		StartOffset = Random.Range (0.0f, 6.2831853f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x,OriginalY+Mathf.Cos ((Time.time+StartOffset)*3.3333333f*bobbleSpeed)*bobbleHeight,transform.position.z);
	}
}
