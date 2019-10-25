using UnityEngine;
using System.Collections;

public class defensa : MonoBehaviour {

    // Is trigger desactivado
void OnCollisionEnter()

    {
        Debug.Log("CollisionEnter");
    }

void OnTriggerEnter()
        {
            Debug.Log("TriggerEnter");
        }
    
}

