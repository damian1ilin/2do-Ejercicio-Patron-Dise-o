using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryManager : MonoBehaviour
{
    
    public Factory FabricaDeEsferas;
    public Factory FabricaDeCubos;

    public Accionador accionador1Q;
    public Accionador accionador2W;


    void Update()
    {
        Controles();
    }


    void Controles(){

        if (Input.GetKeyDown(KeyCode.Alpha1)){
                FabricaDeEsferas.SpawnObjeto();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)){
                FabricaDeCubos.SpawnObjeto();
        }
        
        if (Input.GetKeyDown(KeyCode.Q)){
                accionador1Q.Accionar();
        }

        if (Input.GetKeyDown(KeyCode.W)){
                accionador2W.Accionar();
        }
    }
}
