using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestruyeGemaVerde2 : MonoBehaviour {


    public GameObject Fxparticulas;
    private Transform Player2;
	private Transform Box006;
	private Text puntocp1;
	

	void Start()
	{

		puntocp1 = GameObject.FindWithTag("TEXT01a").GetComponent<Text>();
		Player2 = GameObject.FindWithTag("player2cont").GetComponent<Transform>();
		Box006 = GameObject.FindWithTag("player2cont2").GetComponent<Transform>();

	}

	void OnTriggerEnter(Collider other)

	{

		if (other.tag == "Laser1") return;
		if (other.tag == "Laser2") return;
		if (other.tag == "Boudary") return;
        if (other.tag == "GEMAS") return;
        if (other.tag == "barrasp1") return;
        if (other.tag == "player2cont") return;
        if (other.tag == "ToPlayer1") return;
			
		if (other.tag == "ToPlayer2")


        Player2.transform.localScale = new Vector3(0.349f, 0.625f, 0.449f);
        Box006.transform.localScale = new Vector3(1.0f, 0.618f, 0.861f);
        puntocp1.enabled = true;
		Instantiate(Fxparticulas, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }


	

	
}
