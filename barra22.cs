using UnityEngine;
using System.Collections;

public class barra22 : MonoBehaviour {

    public float velocidad = 10f;
    private Rigidbody rig;
    Vector3 posicionInicial2;
    public float xMin, xMax, zMin, zMax;

    // Use this for initialization
    void Awake()
    {
        rig = GetComponent<Rigidbody>();
		posicionInicial2  = new Vector3(transform.position.x, 0f, transform.position.z);
    }
    public void Reset()
    {
        transform.position = posicionInicial2;
    }
    // Update is called once per frame
    void Update()
    {

        float tecladoHorizontal = Input.GetAxisRaw("Horizontal");
        float posX = transform.position.x + (tecladoHorizontal * velocidad * Time.deltaTime);
        float tecladoVertical = Input.GetAxisRaw("Vertical");
        float posZ = transform.position.z + (tecladoVertical * velocidad * Time.deltaTime);
        transform.position = new Vector3(posX, transform.position.y, posZ);
        rig.position = new Vector3(Mathf.Clamp(rig.position.x, xMin, xMax), 0f, Mathf.Clamp(rig.position.z, zMin, zMax));
    }
}

