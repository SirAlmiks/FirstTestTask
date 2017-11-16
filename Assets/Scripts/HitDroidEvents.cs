using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDroidEvents : MonoBehaviour {

	private GameObject
	droneHit,
	droneDead,
	clone1, clone2;
	//prefabs
	private Transform drone; //coordinates of drone

	void Start()
	{
		droneHit = Resources.Load("Prefabs/ExplosionHit") as GameObject;
		droneDead = Resources.Load("Prefabs/ExplosionDead") as GameObject;
		drone = GameObject.FindGameObjectWithTag ("Drone").GetComponent<Transform> ();
	}
	public void Hit()
	{
		clone1 = Instantiate(droneHit, drone.position, drone.rotation, drone) as GameObject; 
	}

	public void Boom()
	{
		clone2 = Instantiate(droneDead, drone.position, drone.rotation, drone) as GameObject;
	}

	public void Clear()
	{
		Destroy (clone1);
		Destroy (clone2);
	}
}
