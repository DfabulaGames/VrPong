using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class Congratulation : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
           
			SceneManager.LoadScene("VRPPortada");
        }
        
    }
}
