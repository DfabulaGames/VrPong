using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class Opciones1 : MonoBehaviour {

	
	
	// Update is called once per frame
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButtonDown("Fire2"))
		{
			Vidas1.vidas = 3;
			Vidas1.vidas = 3;
			SceneManager.LoadScene("VRPVlevel1");
		}

	}
}