using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public Rigidbody rig;
    public GameObject pelota;
    Vector3 posicionInicial;
    public Transform target;
    public float speed;
    // Use this for initialization
    void Start ()
    {
		posicionInicial  = new Vector3(transform.position.x, 0f, transform.position.z);
    }

    public void Reset()
    {
        transform.position = posicionInicial;
    }

    // Update is called once per frame
    void Update () {

        if (pelota.transform.position.z > 0)
        if (pelota.transform.position.x > transform.position.x)
        {
            transform.position = new Vector3(transform.position.x + 0.7f, transform.position.y, transform.position.z);
        }

        if (pelota.transform.position.x < transform.position.x)
        {
            transform.position = new Vector3(transform.position.x - 0.7f, transform.position.y, transform.position.z);
        }
        if (pelota.transform.position.z > transform.position.z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.6f);
        }

        if (pelota.transform.position.z < transform.position.z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.6f);
        }
		if (pelota.transform.position.z < 0)
		{
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step); 
		}
    }
}