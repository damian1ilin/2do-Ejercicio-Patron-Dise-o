using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public Interactuable ObjetoASpawnear;

    public Accionador miAccionador;

    public void SpawnObjeto(){
        Interactuable a = Instantiate(ObjetoASpawnear);

        float randx = Random.Range(-2.4f,2.4f);
        float randz = Random.Range(-4.3f,4.3f);
        a.transform.position = new Vector3(randx, 1,randz);

        miAccionador.lista.Add(a);
    }
}
