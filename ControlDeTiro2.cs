using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeTiro2 : MonoBehaviour {

	public GameObject shot;
	public Transform ShotSpawn3;
	public float delay;
	public float fireRate;

	bool detener;

	void OnEnable ()
	{	
		detener = false;
		StartCoroutine (Dispara());
	}

	void OnDisable ()
	{		

		detener = true;
	}


	IEnumerator Dispara()
	{		
		int c = 0;
		while (!detener)
		{		
			
			Instantiate(shot, ShotSpawn3.position, ShotSpawn3.rotation);
			yield return new WaitForSeconds (0.8f);
			c++;

		}

	}



	void Update ()

	{		


	}
	

	void Fire() 
	{
		//Instantiate(shot, ShotSpawn3.position, ShotSpawn3.rotation);

	}
}
