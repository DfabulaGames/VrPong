using UnityEngine;
using System.Collections;

public class ChangeTag : MonoBehaviour {
	
	public GameObject Pelota01;
	public GameObject barras;
	public GameObject barras2;

	void start()
	{
		Pelota01 = GameObject.FindWithTag ("ToPlayer01");
	}

	void OnCollisionEnter(Collision coll){
		
		GameObject other = coll.gameObject;

		if (other.tag == ("Laterales")) return;

		if (other.tag == ("player2cont"))
		Pelota01.tag = "ToPlayer2";

		if (other.tag == ("barrasp1"))
			Pelota01.tag = "ToPlayer1";
		
	}
}   
