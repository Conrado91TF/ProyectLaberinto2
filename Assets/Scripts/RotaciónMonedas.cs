using UnityEngine;

public class RotaciónMonedas : MonoBehaviour
{
    [SerializeField]
    float rotacionZ = 100f;

    void Update()
    {
        transform.Rotate(0f, 0f,  rotacionZ * Time.deltaTime);
    }

}
