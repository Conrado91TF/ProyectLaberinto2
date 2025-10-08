using UnityEngine;
using TMPro;

public class SistemeDeMonedas : MonoBehaviour
{
    public int cantidadMonedas;
    public TextMeshProUGUI Numero;

    // Poner tag en todas las moneadas
    //La destrucción de monedas se la tenemos que poner al jugador para que funcione.

    private void Update()
    {
        Numero.text = cantidadMonedas.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Monedas"))
        {
            Destroy(other.gameObject);
            cantidadMonedas++;
        }

    }
}
