using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour {
    public Rigidbody rig;
    public GameObject pelota;
    Vector3 posicionInicial2;

    // Use this for initialization
    void Start ()
    {
		posicionInicial2  = new Vector3(transform.position.x, 0f, transform.position.z);
    }

    public void Reset()
    {
        transform.position = posicionInicial2;
    }

    // Update is called once per frame
    void Update () {


        if (pelota.transform.position.x > transform.position.x)
        {
            transform.position = new Vector3(transform.position.x + 0.4f, transform.position.y, transform.position.z);
        }

        if (pelota.transform.position.x < transform.position.x)
        {
            transform.position = new Vector3(transform.position.x - 0.4f, transform.position.y, transform.position.z);
        }
        if (pelota.transform.position.z > transform.position.z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.7f);
        }

        if (pelota.transform.position.z < transform.position.z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.7f);
        }
    }
}