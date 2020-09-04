using UnityEngine;

public class Comida : MonoBehaviour
{
    private void Update()
    {
        this.transform.Rotate(5f * Time.deltaTime, 5f * Time.deltaTime, 5f * Time.deltaTime);
    }
}
