using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LaneController : MonoBehaviour {
	public enum SpecifiedLane{Lane1 = 0,Lane2 = 1,Lane3 = 2,Lane4 = 3,Lane5 = 4,Lane6 = 5,Lane7 = 6,Lane8 = 7,Lane9 = 8,Lane10 = 9,Lane11 = 10,Lane12 = 11,Lane13 = 12,Lane14 = 13,Lane15 = 14,Lane16 = 15}
	public SpecifiedLane lane = SpecifiedLane.Lane1;
	public Color LaneColor = Color.white;
	public Text LaneNumber;
	public InputField PlayerName;
	public Slider ColorPicker;

	private float ColorPos;
	public string PlayerNam;

	private KeyCheacker keyCheacker;

	// Use this for initialization
	void Start () {
		keyCheacker = GetComponent<KeyCheacker> ();
		LoadData ();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateData ();
		SaveData ();
	}
	void UpdateData() {
		LaneNumber.text = (((int)lane) + 1).ToString("D2");
		PlayerNam = PlayerName.text;
		ColorPos = ColorPicker.value;
		LaneColor = LaneMaths.SingleToHue (ColorPos);
	}
	void LoadData() {
		ColorPos = PlayerPrefs.GetFloat ("LaneColor" + ((int)lane));
		PlayerNam = PlayerPrefs.GetString ("PlayerName" + ((int)lane));
		keyCheacker.Keys [0] = (KeyCode)Enum.Parse (typeof(KeyCode), PlayerPrefs.GetString ("LeftKey" + ((int)lane)));
		keyCheacker.Keys [1] = (KeyCode)Enum.Parse (typeof(KeyCode), PlayerPrefs.GetString ("RightKey" + ((int)lane)));
		keyCheacker.LoadNames();
		ColorPicker.value = ColorPos;
		PlayerName.text = PlayerNam;
	}
	void SaveData() {
		PlayerPrefs.SetFloat ("LaneColor" + ((int)lane),ColorPos);
		PlayerPrefs.SetString ("PlayerName" + ((int)lane),PlayerNam);
		PlayerPrefs.SetString ("LeftKey" + ((int)lane),keyCheacker.Keys[0].ToString());
		PlayerPrefs.SetString ("RightKey" + ((int)lane),keyCheacker.Keys[1].ToString());
	}
}
public class LaneMaths{
	
	public static Color SingleToHue(float Place){//Changes a Single into a Color
		Place = 1.0f-Mathf.Clamp01(Place);
		Color[] col = new Color[2];
		for (int i = 0; i<2;i++){
			int num = (Mathf.FloorToInt((1-Place)*6)+i);
			col[i] = new Color((num<2||num>4)?1.0f:0.0f,(num<4&&num>0)?1.0f:0.0f,(num<6&&num>2)?1.0f:0.0f,1.0f);
		}
		return Color.Lerp(col[0],col[1],((1-Place)*6)%1.0f);
	}
}
