using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimientoEjeZ = Input.GetAxis("Vertical") * Time.deltaTime;
        movimientoEjeX = + Input.GetAxis("Horizontal") * Time.deltaTime;
        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);
    }
}
