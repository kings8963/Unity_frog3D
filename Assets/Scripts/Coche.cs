using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coche : MonoBehaviour
{
   [SerializeField] public float velocidad = 1f;

    // Update is called once per frame
    private void Update()
    {
        this.transform.position = this.transform.position + (this.transform.forward * this.velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider otro)
    {
        if (otro.gameObject.GetComponent<ControlesRana>() != null)
        {
            otro.gameObject.GetComponent<ControlesRana>().Aplastar();
        }
    }
}
