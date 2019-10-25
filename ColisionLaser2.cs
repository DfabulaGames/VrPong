using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColisionLaser2 : MonoBehaviour {

	public GameObject Fxparticulas;
	public DisparoPlayer1 disparoplayer1;
	public Text Textdestroy;
	public GameObject Player1;
	public Text Textcap1a;
	public Text Textcap1b;
	public Text Textcap1c;

	void start()
	{
		GameObject.FindWithTag ("Laser2");
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "barrasp1") return;
		if (other.tag == "Boudary") return;
		if (other.tag == "ToPlayer1") return;
		if (other.tag == "ToPlayer2") return;
		if (other.tag == "GEMAS") return;
		if (other.tag == "Laser1") return;

		if (other.tag == "Laser2")
			Textdestroy.enabled = false;
			Textcap1a.color = Color.white;
		    Textcap1b.color = Color.white;
		    Textcap1c.color = Color.white;
		    disparoplayer1.enabled = false;
		    Instantiate (Fxparticulas, transform.position, Quaternion.identity);
			Player1.transform.localScale = new Vector3 (0.6f, 1.47f, 1.157f);
			

		     
		    
	}
}
