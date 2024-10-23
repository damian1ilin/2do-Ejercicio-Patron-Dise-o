using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo2 : Interactuable
{
    bool rotacion = true;
    public Transform mitransform;
    public override void interactuar()
    {
        rotacion = !rotacion;
    }

    void Start()
    {
        mitransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rotacion){
            mitransform.rotation = Random.rotation;
        }
    }
}
