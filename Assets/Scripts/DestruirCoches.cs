using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirCoches : MonoBehaviour
{
    private void OnTriggerEnter(Collider otro)
    {
        if (otro.gameObject.GetComponent<Coche>() != null)
        {
             Destroy(otro.gameObject);
           
        }
    }
}
