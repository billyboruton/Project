using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HandlePreview : MonoBehaviour {
	public LaneController Lane;
	private Image Display;
	// Use this for initialization
	void Start () {
		Display = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		Display.color = Lane.LaneColor;
	}
}
