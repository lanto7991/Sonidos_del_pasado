using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class DetectarJugadorCerca : MonoBehaviour
{
    
    public UnityEvent eventoEntrar;
    public UnityEvent eventoSalir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("El jugador ha entrado en el trigger");
        if(other.CompareTag("Player")){
            eventoEntrar.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Debug.Log("El jugador ha salido del trigger");
        if(other.CompareTag("Player")){
            eventoSalir.Invoke();
        }
    }

}
