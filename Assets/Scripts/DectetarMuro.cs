using System.Diagnostics;
using UnityEngine;

public class DectetarMuro : MonoBehaviour
{
    //Dectetar la colision del Player en los muros
    [SerializeField]
    Material materialDeRoca;

    [SerializeField]
    Material materialMuroTocada;

    bool muroRojo = false;

    float tiempoRojo = 5f;

    //funcion que se ejecuta por cada imagen del juego
    private void Update()
    {
        if (muroRojo == true)
        {
            tiempoRojo = tiempoRojo - Time.deltaTime;
            if (tiempoRojo < 0.0f)
            {

                gameObject.GetComponent<MeshRenderer>().material = materialDeRoca;
                muroRojo = false;
                tiempoRojo = 5f;
                
            }
        }
    }

    // funcion que se ejecuta al chocar con otro 
    private void OnCollisionEnter(Collision col)
    {
        

        if (col.gameObject.tag == "Player")
        {
           

            gameObject.GetComponent<MeshRenderer>().material = materialMuroTocada;
            muroRojo = true;


        }

         
            
        
    }

}
