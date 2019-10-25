using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class EmpezarPartida : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            Vidas1.vidas = 3;
            Vidas1.vidas = 3;
			SceneManager.LoadScene("VRPOpciones");
        }
        
    }
}
