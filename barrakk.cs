using UnityEngine;
using UnityStandardAssets;
using UnityStandardAssets.CrossPlatformInput;

public class barrakk : MonoBehaviour
{
   
    public float speed = 2f;
    private Rigidbody rig;
    Vector3 posicionInicial;
    public float xMin, xMax, zMin, zMax;

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
    void Update()
    {

       

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        rig.velocity = movement * speed;

        rig.position = new Vector3(Mathf.Clamp(rig.position.x, xMin, xMax), 0f, Mathf.Clamp(rig.position.z, zMin, zMax));
    }
}