using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasPositionVR : MonoBehaviour {
    public RectTransform posicion;
    Vector3 posicionInicial;

    void Awake()
    {
        GetComponent<RectTransform>();

        transform.position = new Vector3(-34f, 137f, 663f);

    }

    public void Reset()
    {
    }
}
