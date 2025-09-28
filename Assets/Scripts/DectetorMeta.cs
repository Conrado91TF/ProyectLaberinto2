using UnityEngine;

public class DectetorMeta : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("jugador llego a la meta");
            pantallaFinal.SetActive(true);
            other.GetComponent<PlayerMovement>().enabled = false;

        
        }

    }

}
