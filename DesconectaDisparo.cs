using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesconectaDisparo : MonoBehaviour {
	
	private DisparoPlayer1 disparoPlayer1;
	public GameObject Fxparticulas;
	private Text puntocp1;
	private Text puntocp2;
	private Text puntocp3;
	void Start()
	{

		disparoPlayer1 = GameObject.FindWithTag("barrasp1").GetComponent<DisparoPlayer1>();
		puntocp1 = GameObject.FindWithTag("TEXT01").GetComponent<Text>();
		puntocp2 = GameObject.FindWithTag("TEXT02").GetComponent<Text>();
		puntocp3 = GameObject.FindWithTag("TEXT03").GetComponent<Text>();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Boudary") return;
        if (other.tag == "barras2") return;
        if (other.tag == "barrasp1") return;
		if (other.tag == "player2cont") return;
        if (other.tag == "ToPlayer2") return;
        if (other.tag == "Laser1") return;
        if (other.tag == "Laser2") return;
        if (other.tag == "GEMAS") return;

        if (other.tag == "ToPlayer1")
			puntocp1.color = Color.white;
			puntocp2.color = Color.white;
			puntocp3.color = Color.white;
	    	disparoPlayer1.enabled = false;
			Instantiate (Fxparticulas, transform.position, Quaternion.identity);
			Destroy(gameObject);

	}


	

	
}
