using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitedeJuego : MonoBehaviour {


	void OnTriggerExit(Collider other)
	{
		Destroy (other.gameObject);
		
	}
}
