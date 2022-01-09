using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//API - para permitirnos comunicarnos con los objetos del proyecto
public class Example : MonoBehaviour //todo script que contenga monobehaviour se puede usar como componente y puede ir en la escena 
{
    // Start is called before the first frame update
    void Start() //se ejecuta una sola vez
    {

    }

    // Update is called once per frame
    void Update() //Se ejecuta 1 vez cada fotograma (frame) y mientras el objeto esté habilitado.
    {
        Debug.Log("Me estoy ejecutando en un Update");  
    }
}
