using UnityEngine;
using System.Collections;

public class barran2 : MonoBehaviour {

    public float velocidad = 2f;
    private Rigidbody rig;
    Vector3 posicionInicial;
    public float xMin, xMax, zMin, zMax;
	// Use this for initialization
    void Awake()
    {
        rig = GetComponent<Rigidbody>();
        posicionInicial = transform.position;
    }

    public void Reset()
    {
        transform.position = posicionInicial;
    }
    // Update is called once per frame
    void Update(){
       
        float tecladoHorizontal = Input.GetAxisRaw("Horizontal2");
        float posX = transform.position.x + (tecladoHorizontal * velocidad * Time.deltaTime);
        float tecladoVertical = Input.GetAxisRaw("Vertical2");
        float posZ = transform.position.z + (tecladoVertical * velocidad * Time.deltaTime);
        transform.position = new Vector3(posX, transform.position.y, posZ);
        rig.position = new Vector3(Mathf.Clamp(rig.position.x, xMin, xMax), 0f, Mathf.Clamp(rig.position.z, zMin, zMax));
    }
}
