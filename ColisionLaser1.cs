using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ColisionLaser1 : MonoBehaviour {

	public GameObject Fxparticulas;
	public ControlDeTiro2 controldetiro;
    public DisparoPlayer2 disparoplayer2;
    public Text Textdestroy;
	public GameObject Player2;
	public GameObject Box006;
	public Text Textcap2a;
	public Text Textcap2b;
	public Text Textcap2c;

	void start()
	{
		GameObject.FindWithTag ("Laser1");
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "barras2") return;
		if (other.tag == "Boudary") return;
		if (other.tag == "ToPlayer1") return;
		if (other.tag == "ToPlayer2") return;
		if (other.tag == "GEMAS") return;
		if (other.tag == "Laser2") return;

		if (other.tag == "Laser1")
			Textdestroy.enabled = false;
			Textcap2a.color = Color.white;
		    Textcap2b.color = Color.white;
		    Textcap2c.color = Color.white;
		    controldetiro.enabled = false;
            disparoplayer2.enabled = false;
            Instantiate (Fxparticulas, transform.position, Quaternion.identity);
			Player2.transform.localScale = new Vector3 (0.22f, 0.6257735f, 0.4493761f);
			Box006.transform.localScale = new Vector3 (1.62f, 0.618f, 0.861f);
	    	Time.timeScale = 1;
		     
		    
	}
}
