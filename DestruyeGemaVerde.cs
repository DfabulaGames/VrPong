using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestruyeGemaVerde : MonoBehaviour {

	private Transform Object001;
	private MeshRenderer disparoPlayer1;
	public GameObject Fxparticulas;
	private Text puntocp1;
	void Start()
	{

		
		puntocp1 = GameObject.FindWithTag("TEXT01").GetComponent<Text>();
		Object001 = GameObject.FindWithTag("barrasp1").GetComponent<Transform>();

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Laser1") return;
		if (other.tag == "Laser2") return;
		if (other.tag == "Boudary") return;
        if (other.tag == "GEMAS") return;
        if (other.tag == "barrasp1") return;
		if (other.tag == "barras2") return;
		if (other.tag == "ToPlayer2") return;
        if (other.tag == "player2cont2") return;

        if (other.tag == "ToPlayer1")
		puntocp1.enabled = true;
		Object001.transform.localScale = new Vector3 (0.902f, 1.47f, 1.157f);
		Instantiate (Fxparticulas, transform.position, Quaternion.identity);
		Destroy(gameObject);
		
	}


	

	
}
