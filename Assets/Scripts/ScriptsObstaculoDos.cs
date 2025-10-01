using UnityEngine;
using UnityEngine.Animations;

public class ScriptsObstaculoDos : MonoBehaviour
{
    [SerializeField] float Velocidad = 1f;  // Velocidad de movimiento del Obstaculo
    [SerializeField] float Distancia = 2f; //Distacia maxima 

    private Vector3 posicionInicial;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posicionInicial = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        float desplazamiento = Mathf.PingPong(Time.time * Velocidad, Distancia);
        transform.position = posicionInicial + transform.forward * desplazamiento;
    }
}
