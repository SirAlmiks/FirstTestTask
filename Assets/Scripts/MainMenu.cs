using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	private GameObject
	MainAnim,
	UIText;
	bool isStart = false; //проверка - началось ли уже действие

	void Start () {
		MainAnim = Resources.Load("Prefabs/CV_BT_ROBOT_07") as GameObject;
		UIText = GameObject.Find("UI");
	}
	
	void Update () {		
		
		if (Input.touchCount > 0 && !isStart)
		{
			GameObject	clone = Instantiate(MainAnim) as GameObject;
			Destroy (UIText);
			isStart = true;
		}
	}
	
	}