using UnityEngine;
using System.Collections;

public class barra : MonoBehaviour {

    public float velocidad = 2f;
    private Rigidbody rig;
    Vector3 posicionInicial;
    public float xMin, xMax, zMin, zMax;
	// Use this for initialization
    void Awake()
    {
        rig = GetComponent<Rigidbody>();
        posicionInicial = new Vector3(-0.1400757f, 2f, -33.4f);
    }

    public void Reset()
    {
        transform.position = posicionInicial;
    }
    // Update is called once per frame
    void Update(){
       
        float tecladoHorizontal = Input.GetAxisRaw("Horizontal");
        float posX = transform.position.x + (tecladoHorizontal * velocidad * Time.deltaTime);
        float tecladoVertical = Input.GetAxisRaw("Vertical");
        float posZ = transform.position.z + (tecladoVertical * velocidad * Time.deltaTime);
        transform.position = new Vector3(posX, 2f, posZ);
        rig.position = new Vector3(Mathf.Clamp(rig.position.x, xMin, xMax), 0f, Mathf.Clamp(rig.position.z, zMin, zMax));
    }
}
