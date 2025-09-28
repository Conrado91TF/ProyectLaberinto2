using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;

    public float velocidadDeMovimiento = 1.5f;
    

    // Update is called once per frame
    void Update()
    {
        //Movimiento del Player y Velocidad
        movimientoEjeZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidadDeMovimiento;
        movimientoEjeX = +Input.GetAxis("Horizontal") * Time.deltaTime * velocidadDeMovimiento;
        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);
    }
}
