﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class DisparoPlayer1 : MonoBehaviour {


	public GameObject Rayodoble;
	public Transform ShotSpawn;
	public float fireRate;
	private float nextFire;


	void Update () 
	{
		if (CrossPlatformInputManager.GetButtonDown("Fire2") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate (Rayodoble, ShotSpawn.position, ShotSpawn.rotation);
		}
	
	else
	{
		if ((Input.GetKey(KeyCode.JoystickButton2) && Time.time > nextFire) == true)
		{
			nextFire = Time.time + fireRate;
			Instantiate (Rayodoble, ShotSpawn.position, ShotSpawn.rotation);
		}
	}
}
}   