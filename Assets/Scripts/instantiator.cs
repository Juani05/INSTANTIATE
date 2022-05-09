using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public void CloneObject()
    {
        int contador = 0;
        while (contador < 3)
        {
            Instantiate(objectToClone);
            contador++;
        }
        }
}
