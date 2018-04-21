using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Text;
using System;

public class KeyCheacker : MonoBehaviour {
	bool[] CheackKey = new bool[2];
	public Text[] ButtonsText = new Text[2];
	public KeyCode[] Keys = new KeyCode[2] {KeyCode.None,KeyCode.None};
		// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		for (int K = 0; K < 2; K++) {
			if (CheackKey [K]) {
				ChangeKeyRun (K);
			}
		}
	}
	public void OnButton0Click(){
		CheackKey [0] = true;
	}
	public void OnButton1Click(){
		CheackKey [1] = true;
	}
	public void ChangeKeyRun (int ButtontoChange)
	{
		foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode))) {
			if (Input.GetKeyDown (vKey)) {
				Keys [ButtontoChange] = vKey;
				if (vKey.ToString() == "Alpha0"||vKey.ToString() == "Alpha1"||vKey.ToString() == "Alpha2"||vKey.ToString() == "Alpha3"||vKey.ToString() == "Alpha4"||vKey.ToString() == "Alpha5"||vKey.ToString() == "Alpha6"||vKey.ToString() == "Alpha7"||vKey.ToString() == "Alpha8"||vKey.ToString() == "Alpha9") {
					ButtonsText [ButtontoChange].text = vKey.ToString().Substring(5,1);
				} else {
					ButtonsText [ButtontoChange].text = vKey.ToString ();
				}
				CheackKey [ButtontoChange] = false;
			}
		}
	}
	public void LoadNames(){
		for (int i = 0; i < 2; i++) {
			if (Keys[i].ToString() == "Alpha0"||Keys[i].ToString() == "Alpha1"||Keys[i].ToString() == "Alpha2"||Keys[i].ToString() == "Alpha3"||Keys[i].ToString() == "Alpha4"||Keys[i].ToString() == "Alpha5"||Keys[i].ToString() == "Alpha6"||Keys[i].ToString() == "Alpha7"||Keys[i].ToString() == "Alpha8"||Keys[i].ToString() == "Alpha9") {
				ButtonsText[i].text = Keys[i].ToString().Substring(5,1);
			} else {
				ButtonsText[i].text = Keys[i].ToString ();
			}
		}
	}
}