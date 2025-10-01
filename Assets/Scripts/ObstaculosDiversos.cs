using UnityEngine;

public class ObstaculosDiversos : MonoBehaviour
{
    [SerializeField]
    float rotacionY = 10f; 

    //Rotaci�n del obstaculo en el eje Y
    void Update()
    {
        transform.Rotate(0.0f, rotacionY * Time.deltaTime, 0f);

    }
}
