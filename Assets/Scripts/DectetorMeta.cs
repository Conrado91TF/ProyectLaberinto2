using UnityEngine;
using TMPro;

public class DectetorMeta : MonoBehaviour
{
    // Final de la meta
    [SerializeField]
    GameObject pantallaFinal;

    //Etiqueta de tiempo

    [SerializeField] 
    TextMeshProUGUI textoLabeTime;
        

    // Contador de tiempo
    float tiempoDePartida = 0.0f;
    bool estaJugando = true;

    private void Update()
    {
        if (estaJugando == true)
        {
            tiempoDePartida = tiempoDePartida + Time.deltaTime;

        }

    }
    // El jugador llega a la meta
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("jugador llego a la meta");
            pantallaFinal.SetActive(true);
            other.GetComponent<PlayerMovement>().enabled = false;
            estaJugando = false;
            textoLabeTime.text = tiempoDePartida.ToString();





        }

    }

}
