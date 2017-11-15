using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalOpenTrigger : MonoBehaviour {

	private GameObject
	aura01,
	aura02,
	aura03,
	aura04,
	glow_effect,
	smoke_around_hole,
	ground_storm,
	dark_hole;
	//Список объектов для взаимодействия


	void Start () {
		aura01 = GameObject.Find ("aura01");
		aura02 = GameObject.Find ("aura02");
		aura03 = GameObject.Find ("aura03");
		aura04 = GameObject.Find ("aura04");
		glow_effect = GameObject.Find ("glow_effect");
		smoke_around_hole = GameObject.Find ("smoke_around_hole");
		ground_storm = GameObject.Find ("ground_storm");
		dark_hole = GameObject.Find ("dark_hole");

	}

	public void OpenPortal()
	{
		aura01.SetActive(true);
		aura02.SetActive(true);
		aura03.SetActive(true);
		aura04.SetActive(true);
		glow_effect.SetActive(true);
		smoke_around_hole.SetActive(true);
		ground_storm.SetActive(true);
		dark_hole.SetActive(true);
	}

	public void ClosePortal()
	{
		aura01.SetActive(false);
		aura02.SetActive(false);
		aura03.SetActive(false);
		aura04.SetActive(false);
		glow_effect.SetActive(false);
		smoke_around_hole.SetActive(false);
		ground_storm.SetActive(false);
		dark_hole.SetActive(false);
	}
}
