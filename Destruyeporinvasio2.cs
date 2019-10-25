using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Destruyeporinvasio2 : MonoBehaviour {

	public GameObject Fxparticulas;
	private ControlDeTiro2 controldetiro2;
    
    private Text puntocp1;
	private Text puntocp2;
	private Text puntocp3;



	void Start()
	{

		controldetiro2 = GameObject.FindWithTag("barras2").GetComponent<ControlDeTiro2>();
     
        puntocp1 = GameObject.FindWithTag("TEXT01a").GetComponent<Text>();
		puntocp2 = GameObject.FindWithTag("TEXT01b").GetComponent<Text>();
		puntocp3 = GameObject.FindWithTag("TEXT01c").GetComponent<Text>();

	}

	void OnTriggerEnter(Collider other)

    {
		if (other.tag == "Boudary") return;

		if (other.tag == "Laser1") return;
		if (other.tag == "Laser2") return;
        if (other.tag == "GEMAS") return;
        if (other.tag == "player2cont") return;
		if (other.tag == "barrasp1") return;

		if (other.tag == "ToPlayer1") return;

		if (other.tag == "ToPlayer2")
		puntocp1.color = Color.red;
		puntocp2.color = Color.red;
		puntocp3.color = Color.red;
		Instantiate (Fxparticulas, transform.position, Quaternion.identity);
        controldetiro2.enabled = true;
        
        Destroy(gameObject);


    }
}
