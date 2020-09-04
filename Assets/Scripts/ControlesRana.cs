using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlesRana : MonoBehaviour
{
    [SerializeField] float limiteHorizontal;
    [SerializeField] float limiteVertical;
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            float ejeHorizontal = Input.GetAxisRaw("Horizontal");
            float ejeVertical = Input.GetAxisRaw("Vertical");

            if (ejeHorizontal != 0f)
            {
                if (Mathf.Abs(this.transform.position.x + ejeHorizontal) < this.limiteHorizontal)
                {
                    this.transform.position = new Vector3(this.transform.position.x + ejeHorizontal, this.transform.position.y, this.transform.position.z);
                    this.transform.rotation = Quaternion.Euler(0f, 90f * ejeHorizontal, 0f);
                }
            }

            else
            {
                if (ejeVertical != 0f)
                {
                    if (Mathf.Abs(this.transform.position.z + ejeVertical) < this.limiteVertical)
                    {
                        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + ejeVertical);
                        if (ejeVertical > 0f)
                        {
                            this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                        }
                        else
                        {
                            this.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                        }
                    }
                   
                }

            }
        }
        
    }

    public void Aplastar() 
    {
        this.GetComponent<Animator>().SetTrigger("cocheAplastoRana");
    }
       
}
