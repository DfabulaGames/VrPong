using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeTiro : MonoBehaviour {

	public GameObject shot;
	public Transform ShotSpawn3;
	public float delay;
	public float fireRate;

	// Use this for initialization
	void OnEnable ()
	{		
			InvokeRepeating("Fire", delay, fireRate);	
	
	}
	void Update ()
	{		


	}
	void Fire() 
	{
		Instantiate(shot, ShotSpawn3.position, ShotSpawn3.rotation);

	}
}
