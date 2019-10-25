using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gema1controller : MonoBehaviour {

	public GameObject Gema;
	public Vector3 spawnValues;
	public int GemasCount;
	public float spawnWait;
	public float startWait;
	public float continueWait;
	void Start () {
		
		StartCoroutine(CreaGema());
		
	}
	

	IEnumerator CreaGema () {
		yield return new WaitForSeconds (startWait);
		while (true)
	for(int i=0; i < GemasCount; i++)
		
	{
		Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x),spawnValues.y, Random.Range(-spawnValues.z, spawnValues.z));
		Instantiate (Gema, spawnPosition, Quaternion.identity);
		yield return new WaitForSeconds (spawnWait);
	}
		yield return new WaitForSeconds (continueWait);
}
}