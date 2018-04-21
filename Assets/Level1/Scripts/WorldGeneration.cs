using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class WorldGeneration : MonoBehaviour {
	public float lengthOfCircuit = 500.0f;
	public float flagEvery = 250.0f;
	public int BouysBetweenFlags = 8;
	public Vector3 Origin;
	public float OriginRotation;
	public Vector3 GetEnd{
		get{ 
			float y = Origin.y;
			float x = lengthOfCircuit * Mathf.Sin (OriginRotation);
			float z = lengthOfCircuit * Mathf.Cos (OriginRotation);
			return new Vector3 (x, y, z);
		}
	}
	public Vector3 theend;
	public GameObject BaseBouy;
	public GameObject BaseFlag;
	public GameObject[] Bouys;
	public GameObject[] Flags;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		theend = GetEnd;

	}
	void SetBouys(){
		int arraylength = Mathf.RoundToInt((lengthOfCircuit / flagEvery) * BouysBetweenFlags);
		if (Bouys.Length != arraylength) {
			
		}
	}
	void SetFlags(){

	}
}
