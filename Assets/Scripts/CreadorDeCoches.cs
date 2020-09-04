using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorDeCoches : MonoBehaviour
{
    [SerializeField] private GameObject prefabCoche;
    private float tiempoProximoCoche = 0f;
    private void Start()
    {
        this.tiempoProximoCoche = Time.time + Random.Range(3f, 5f);
    }

    private void Update()
    {

        if (Time.time > tiempoProximoCoche)
        {
            this.CrearCoche();
        }

    }

    private void CrearCoche()
    {

        Instantiate(this.prefabCoche, this.transform.position, this.transform.rotation);
        this.tiempoProximoCoche = Time.time + Random.Range(3f, 5f);

    }

   
}
