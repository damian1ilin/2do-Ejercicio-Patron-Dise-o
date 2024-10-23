using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cilindro : Interactuable
{
    int direccion = 1;
    Transform miTransform;

    private void Start() {
        miTransform = GetComponent<Transform>();
    }

    public override void interactuar()
    {
        Vector3 temp = new Vector3(direccion*0.5f,0f,0f);
        miTransform.position += temp;
        direccion = direccion*-1;
    }
}
